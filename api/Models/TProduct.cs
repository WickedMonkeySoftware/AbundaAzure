using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace api.Models
{
    public class TProduct
    {
        public string ProductCode
        {
            get;
            set;
        }

        public int Qty
        {
            get;
            set;
        }

        private CloudStorageAccount cloud;
        private CloudTableClient client;
        private CloudTable products;

        private string merchantID;
        private string marketplaceID;
        private string secretKey;
        private string accessKey;

        private string affiliateCode;
        private string App;

        MarketplaceWebServiceProducts.MarketplaceWebServiceProductsClient amz;

        /// <summary>
        /// The public facing data to send
        /// </summary>
        public dynamic CalculatorView { get; set; }

        /// <summary>
        /// Create a Trade Product
        /// </summary>
        /// <param name="affiliate">The affiliate to attach this scan to</param>
        /// <param name="code">The code to attempt to look up</param>
        /// <param name="qty">The quantity to look up</param>
        /// <param name="force_lookup">Force a refresh lookup (ignore cache)</param>
        public TProduct(string affiliate, string code, int qty, string app, bool force_lookup = false)
        {
            ProductCode = code;
            Qty = qty;
            App = app;
            affiliateCode = affiliate;

            cloud = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("AbundaStorage"));

            client = cloud.CreateCloudTableClient();

            products = client.GetTableReference("Products");
            products.CreateIfNotExists();

            //todo: look up item in cache

            using (var context = new DataBaseDataContext())
            {
                var aff = (from ev in context.Affiliates
                           where ev.code == affiliate
                           select ev).FirstOrDefault();

                merchantID = aff.MerchantID;
                marketplaceID = aff.MarketPlaceID;
                secretKey = aff.SecretKey;
                accessKey = aff.AccessKey;
            }

            var amzResults = PerformAmazonLookup();

            if (amzResults.Count == 0)
            {
                CalculatorView = new { error = "Unknown Item, double check your search" };
                return;
            }

            //todo: get the real product
            var keepProduct = amzResults[0];

            PerformAmazonCompetivePricing(ref keepProduct);
            PerformLowestOfferListing(ref keepProduct, "Used", false);
            PerformLowestOfferListing(ref keepProduct, "New", false);

            //todo: save data in cache

            //todo: save data for retrieval in a list
            var id = SaveItemAsTrade(keepProduct);


            using (var context = new DataBaseDataContext())
            {
                var product = context.TradeProducts.Where(x => x.ID == id).FirstOrDefault();

                CalculatorView = new
                {
                    currency_for_total = "$",
                    id = "0",
                    image = product.Image,
                    imagem = product.Image,
                    imagel = product.Image,
                    price = product.CalculatedOffer,
                    product_code = product.Code,
                    quantity = product.Quantity,
                    title = product.Title,
                    total = product.CalculatedOffer * qty,
                    total_qty = qty,
                    row = new List<dynamic>()
                };

                CalculatorView.row.Add(new { testrow = "data" });
            }
        }

        public int SaveItemAsTrade(AmazonProduct amz)
        {
            using (var context = new DataBaseDataContext())
            {
                TradeProduct product = new TradeProduct();

                var aff = (from ev in context.Affiliates
                           where ev.code == affiliateCode
                           select ev).FirstOrDefault();

                var Category = (from ev in context.AmazonToTradeCategories
                                where ev.AmazonCategory.Title == amz.Group && ev.TradeCategory.Deleted == false && ev.TradeCategory.Affiliate1 == aff
                                select ev).FirstOrDefault();

                if (Category == null)
                {
                    throw new Exception("Unwanted Item");
                }

                product.Affiliate1 = aff;
                product.AcceptablePrice = CalculateLowest(ref amz, "Used", "Acceptable");
                product.AmazonTradeInPrice = amz.TradeInValue;
                //product.AffiliateOffer = 0
                product.ASIN = amz.ASIN;
                if (amz.Author != null)
                {
                    product.Author = amz.Author;
                }
                else if (amz.Director != null)
                {
                    product.Author = amz.Director;
                }
                else if (amz.Artist != null)
                {
                    product.Author = amz.Artist;
                }
                else
                {
                    product.Author = amz.Manufacturer;
                }

                var minprice = getMinimumPrice(ref amz);

                if (Category.TradeCategory.DoTurnBasedCalculations)
                {
                    //todo: check min sellers, and set to a fixed price
                    decimal estimate = minprice.Value;
                    //get cascades
                    var cascades = new List<decimal>();
                    var results = new List<decimal>();

                    for (int i = 1; i <= 7; i++)
                    {
                        decimal cascade;
                        TradeSettingLoader.LoadForAffiliate(aff.ID, "cascade_" + i.ToString(), out cascade);
                        cascades.Add(cascade);
                    }

                    //get turns
                    var turns = (from ev in context.TradeTurns
                                 where ev.TradeCategory == Category.TradeCategory && ev.MinSalesRank < amz.SalesRanks[0].Rank && amz.SalesRanks[0].Rank <= ev.MaxSalesRank && ev.Affiliate1 == aff
                                 select ev.Turns).FirstOrDefault();

                    product.Turns = (int)turns;
                    //get shipping credit
                    decimal shipping;
                    TradeSettingLoader.LoadForAffiliate(aff.ID, "shipping_credit", out shipping);
                    //get min ROI
                    decimal minroi;
                    TradeSettingLoader.LoadForAffiliate(aff.ID, "min_roi", out minroi);
                    //set commision
                    decimal commissionFlat;
                    decimal commissionVar;
                    TradeSettingLoader.LoadForAffiliate(aff.ID, "flat_rate_commission", out commissionFlat);
                    TradeSettingLoader.LoadForAffiliate(aff.ID, "var_rate_commission", out commissionVar);
                    //todo: calculate margin and offer value

                    cascades.Reverse();

                    foreach (var cascade in cascades)
                    {
                        if (-100 * ((turns * (100 * commissionFlat + 100 * commissionVar * estimate + (cascade - 100) * (shipping + estimate))) / (100 * commissionFlat + 100 * commissionVar * estimate + cascade * (shipping + estimate))) >= minroi)
                        {
                            product.CalculatedOffer = (estimate + shipping) * cascade / 100M;
                        }
                    }

                    product.CalculatedOffer = Util.RoundUpToNearest(product.CalculatedOffer, 0.50M);
                }
                else
                {
                    product.Turns = 0;
                }

                //product.BestOffer = 0;
                //product.CalculatedOffer = 0;
                product.TradeCategory = Category.TradeCategory;
                product.Code = ProductCode;
                product.CodeType1 = context.CodeTypes.Where(x => x.Name == CodeType(ProductCode)).FirstOrDefault();
                product.Date = DateTime.UtcNow;
                product.FBAGoodPrice = CalculateLowest(ref amz, "Used", "Good", "Amazon");
                product.FBALikeNewPrice = CalculateLowest(ref amz, "Used", "LikeNew", "Amazon");
                product.FBANewPrice = CalculateLowest(ref amz, "New", "New", "Amazon");
                product.FBAVeryGoodPrice = CalculateLowest(ref amz, "Used", "VeryGood");
                product.GoodPrice = CalculateLowest(ref amz, "Used", "Good");
                product.Image = amz.Image.AbsoluteUri;
                product.ItemReceived = false;
                product.LikeNewPrice = CalculateLowest(ref amz, "Used", "LikeNew");
                product.ListPrice = amz.ListPrice;
                product.NewPrice = CalculateLowest(ref amz, "New", "New");
                product.Note = "";
                product.OverStocked = false;
                product.Quantity = Qty;
                product.SalesRank = (int)amz.SalesRanks[0].Rank;
                product.Title = amz.Title;
                product.Token = "";
                product.TradeApp = context.TradeApps.OrderBy(x => x.Default).Where(x => x.Affiliate1 == aff && (x.Title == App || x.Default == true)).FirstOrDefault();
                product.TradeCondition = context.TradeConditions.Where(x => x.isBaseCondition == true).FirstOrDefault();
                product.VeryGoodPrice = CalculateLowest(ref amz, "Used", "VeryGood");

                context.TradeProducts.InsertOnSubmit(product);
                context.SubmitChanges();

                return product.ID;
            }
        }

        public decimal? getMinimumPrice(ref AmazonProduct amz)
        {
            List<decimal?> First = new List<decimal?>();
            List<decimal?> Second = new List<decimal?>();
            List<decimal?> Third = new List<decimal?>();

            First.Add(CalculateLowest(ref amz, "New", "New", "Merchant"));
            First.Add(CalculateLowest(ref amz, "Used", "LikeNew", "Merchant"));
            First.Add(CalculateLowest(ref amz, "Used", "Mint", "Merchant"));
            First.Add(CalculateLowest(ref amz, "Used", "VeryGood", "Merchant"));
            Second.Add(CalculateLowest(ref amz, "Used", "Good", "Merchant"));
            Second.Add(CalculateLowest(ref amz, "Used", "Acceptable", "Merchant"));
            Third.Add(amz.ListPrice);

            if (First.Count > 2)
            {
                return First.Min();
            }

            if (Second.Count > 2)
                return Second.Min();

            return amz.ListPrice;
        }

        public decimal? CalculateLowest(ref AmazonProduct amz, string Condition, string subCondition = "Any", string Fullfillment = "Merchant")
        {
            //todo: load rules for this

            var results = amz.LowestOfferListing.Where(x => x.Condition == Condition && (subCondition == "Any" ? true : x.SubCondition == subCondition) && x.Fullfillment == Fullfillment);
            if (results.Count() == 0)
            {
                return new Nullable<decimal>();
            }

            return results.Min(x => x.Price.ListPrice);
        }

        public void PerformLowestOfferListing(ref AmazonProduct product, string condition, bool excludeSelf)
        {
            var request = new MarketplaceWebServiceProducts.Model.GetLowestOfferListingsForASINRequest();
            request.ASINList = new MarketplaceWebServiceProducts.Model.ASINListType();
            request.ASINList.ASIN = new List<string>();
            request.ASINList.ASIN.Add(product.ASIN);
            request.ExcludeMe = excludeSelf;
            request.ItemCondition = condition;
            request.MarketplaceId = marketplaceID;
            request.SellerId = merchantID;

            var response = amz.GetLowestOfferListingsForASIN(request);

            if (product.LowestOfferListing == null)
            {
                product.LowestOfferListing = new List<OfferListing>();
            }

            if (response.IsSetGetLowestOfferListingsForASINResult())
            {
                var results = response.GetLowestOfferListingsForASINResult;

                foreach (var result in results)
                {
                    if (result.IsSetAllOfferListingsConsidered())
                    {
                        product.AllOfferListingsUsed = true;
                    }

                    if (result.IsSetProduct())
                    {
                        var prodCap = result.Product;

                        if (prodCap.IsSetLowestOfferListings())
                        {
                            var lowestCap = prodCap.LowestOfferListings;

                            if (lowestCap.IsSetLowestOfferListing())
                            {
                                var lowests = lowestCap.LowestOfferListing;

                                foreach (var lowest in lowests)
                                {
                                    var l = new OfferListing();

                                    if (lowest.IsSetMultipleOffersAtLowestPrice())
                                    {
                                        switch (lowest.MultipleOffersAtLowestPrice)
                                        {
                                            case "True":
                                                l.MultipleOffersAtPrice = TriBool.True;
                                                break;
                                            case "False":
                                                l.MultipleOffersAtPrice = TriBool.False;
                                                break;
                                            default:
                                                l.MultipleOffersAtPrice = TriBool.Unknown;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        l.MultipleOffersAtPrice = TriBool.False;
                                    }

                                    if (lowest.IsSetNumberOfOfferListingsConsidered())
                                    {
                                        var number = lowest.NumberOfOfferListingsConsidered;

                                        l.NumberOfferListings = number;
                                    }

                                    if (lowest.IsSetPrice())
                                    {
                                        var price = lowest.Price;
                                        l.Price = new PriceType() { LandedPrice = price.LandedPrice.Amount, ListPrice = price.ListingPrice.Amount, Shipping = price.Shipping.Amount };
                                    }

                                    if (lowest.IsSetQualifiers())
                                    {
                                        var quals = lowest.Qualifiers;

                                        if (quals.IsSetFulfillmentChannel())
                                        {
                                            l.Fullfillment = quals.FulfillmentChannel;
                                        }

                                        if (quals.IsSetItemCondition())
                                        {
                                            l.Condition = quals.ItemCondition;
                                        }

                                        if (quals.IsSetItemSubcondition())
                                        {
                                            l.SubCondition = quals.ItemSubcondition;
                                        }

                                        if (quals.IsSetSellerPositiveFeedbackRating())
                                        {
                                            l.PositiveFeedbackSetting = quals.SellerPositiveFeedbackRating;
                                        }

                                        if (quals.IsSetShippingTime())
                                        {
                                            var ShippingTime = quals.ShippingTime;

                                            if (ShippingTime.IsSetMax())
                                            {
                                                l.ShippingTime = ShippingTime.Max;
                                            }
                                        }

                                        if (quals.IsSetShipsDomestically())
                                        {
                                            switch (quals.ShipsDomestically)
                                            {
                                                case "True":
                                                    l.ShipsDomestically = TriBool.True;
                                                    break;
                                                case "False":
                                                    l.ShipsDomestically = TriBool.False;
                                                    break;
                                                default:
                                                    l.ShipsDomestically = TriBool.Unknown;
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            l.ShipsDomestically = TriBool.Unknown;
                                        }
                                    }

                                    if (lowest.IsSetSellerFeedbackCount())
                                    {
                                        var feedback = lowest.SellerFeedbackCount;
                                        l.SellerFeedbackCount = feedback;
                                    }

                                    product.LowestOfferListing.Add(l);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void PerformAmazonCompetivePricing(ref AmazonProduct product)
        {
            var request = new MarketplaceWebServiceProducts.Model.GetCompetitivePricingForASINRequest();
            request.ASINList = new MarketplaceWebServiceProducts.Model.ASINListType();
            request.ASINList.ASIN = new List<string>();
            request.ASINList.ASIN.Add(product.ASIN);
            request.MarketplaceId = marketplaceID;
            request.SellerId = merchantID;

            var response = amz.GetCompetitivePricingForASIN(request);

            if (response.IsSetGetCompetitivePricingForASINResult())
            {
                var results = response.GetCompetitivePricingForASINResult;

                if (results.Count() > 1)
                {
                    dynamic temp = new { hello = "world" };
                    temp.hello = "hello";
                }

                foreach (var result in results)
                {
                    if (result.IsSetProduct())
                    {
                        var productCap = result.Product;

                        if (productCap.IsSetCompetitivePricing())
                        {
                            var competitive = productCap.CompetitivePricing;

                            if (competitive.IsSetCompetitivePrices())
                            {
                                var priceCap = competitive.CompetitivePrices;

                                if (priceCap.IsSetCompetitivePrice())
                                {
                                    var prices = priceCap.CompetitivePrice;

                                    product.CompetivePrices = new List<ConditionList>();

                                    foreach (var price in prices)
                                    {
                                        if (price.IsSetcondition() && price.IsSetPrice())
                                        {
                                            var p = new ConditionList();
                                            p.Condition = price.condition;
                                            p.Price = new PriceType();
                                            p.Price.LandedPrice = price.Price.LandedPrice.Amount;
                                            p.Price.ListPrice = price.Price.ListingPrice.Amount;
                                            p.Price.Shipping = price.Price.Shipping.Amount;

                                            if (price.IsSetsubcondition())
                                            {
                                                p.SubCondition = price.subcondition;
                                            }
                                            else
                                            {
                                                p.SubCondition = price.condition;
                                            }

                                            product.CompetivePrices.Add(p);
                                        }
                                    }
                                }
                            }

                            if (competitive.IsSetNumberOfOfferListings())
                            {
                                var offerlistings = competitive.NumberOfOfferListings;

                                if (offerlistings.IsSetOfferListingCount())
                                {
                                    var listings = offerlistings.OfferListingCount;

                                    product.OfferListingCount = new List<ConditionList>();

                                    foreach (var list in listings)
                                    {
                                        if (list.IsSetcondition() && list.IsSetValue())
                                        {
                                            var p = new ConditionList();
                                            p.Condition = list.condition;
                                            p.Count = list.Value;
                                            product.OfferListingCount.Add(p);
                                        }
                                    }
                                }
                            }

                            if (competitive.IsSetTradeInValue())
                            {
                                var tradein = competitive.TradeInValue;

                                product.TradeInValue = tradein.Amount;
                            }
                        }

                        if (productCap.IsSetSalesRankings())
                        {
                            var rankList = productCap.SalesRankings;

                            if (rankList.IsSetSalesRank())
                            {
                                var ranks = rankList.SalesRank;

                                foreach (var rank in ranks)
                                {
                                    if (rank.IsSetProductCategoryId() && rank.IsSetRank())
                                    {
                                        //check for existence
                                        var q = product.SalesRanks.Find(r => r.Category == rank.ProductCategoryId);

                                        if (q != null)
                                        {
                                            q.Rank = rank.Rank;
                                        }
                                        else
                                        {
                                            product.SalesRanks.Add(new SalesRank() { Category = rank.ProductCategoryId, Rank = rank.Rank });
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Determine what kind of barcode something is
        /// </summary>
        /// <param name="code">The code to look up</param>
        /// <returns></returns>
        public string CodeType(string code)
        {
            var custom = @"^CUSTOM.*GADGET.*";
            var promo = @"^[dD]\d+$";
            var promo2 = @"^0208\d+$";
            var isbn = @"^97[89]\d{10}$";
            var ean = @"^\d{13}$";
            var upc = @"^\d{12}$";
            var asin = @"^\w{10}$";

            if (this.Match(code, custom, "yes", "") != "") return "CUSTOMGADGET";
            //if (this.Match(id, promo, "yes","") != "") return "PROMOTIONAL";
            //if (this.Match(id, promo2, "yes", "") != "") return "PROMOTIONAL";
            if (this.Match(code, isbn, "yes", "") != "") return "ISBN";
            if (this.Match(code, ean, "y", "") != "") return "EAN";
            if (this.Match(code, upc, "y", "") != "") return "UPC";
            if (this.Match(code, asin, "y", "") != "") return "ASIN";

            return "UNKNOWN";
        }

        /// <summary>
        /// Finds a regex match
        /// </summary>
        /// <param name="m"></param>
        /// <param name="to"></param>
        /// <param name="t"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        protected string Match(string m, string to, string t, string f)
        {
            var regex = new Regex(to, RegexOptions.IgnoreCase);
            if (regex.Match(m).Success) return t;

            return f;
        }

        /// <summary>
        /// Performs an Amazon Lookup for this object
        /// </summary>
        /// <returns></returns>
        public List<AmazonProduct> PerformAmazonLookup()
        {
            MarketplaceWebServiceProducts.MarketplaceWebServiceProductsConfig config = new MarketplaceWebServiceProducts.MarketplaceWebServiceProductsConfig();
            config.ServiceURL = "https://mws.amazonservices.com/Products/2011-10-01";
            amz = new MarketplaceWebServiceProducts.MarketplaceWebServiceProductsClient("Abundatrade.com", "2.0", accessKey, secretKey, config);

            List<AmazonProduct> AProducts = new List<AmazonProduct>();

            var id_request = new MarketplaceWebServiceProducts.Model.GetMatchingProductForIdRequest();
            id_request.IdList = new MarketplaceWebServiceProducts.Model.IdListType();
            id_request.IdList.Id = new List<string>();
            id_request.IdList.Id.Add(ProductCode);
            id_request.IdType = CodeType(ProductCode);
            id_request.SellerId = merchantID;
            id_request.MarketplaceId = marketplaceID;

            var id_result = amz.GetMatchingProductForId(id_request);

            if (id_result.IsSetGetMatchingProductForIdResult())
            {
                var results = id_result.GetMatchingProductForIdResult;

                foreach (var result in results)
                {
                    if (result.IsSetProducts())
                    {
                        var product_cap = result.Products;

                        if (product_cap.IsSetProduct())
                        {
                            var products = product_cap.Product;

                            foreach (var product in products)
                            {
                                var aproduct = new AmazonProduct();

                                if (product.IsSetIdentifiers())
                                {
                                    var identifiers = product.Identifiers;

                                    if (identifiers.IsSetMarketplaceASIN())
                                    {
                                        var asin_cap = identifiers.MarketplaceASIN;

                                        if (asin_cap.IsSetASIN())
                                        {
                                            var asin = asin_cap.ASIN;

                                            aproduct.ASIN = asin;
                                            aproduct.Code = ProductCode;
                                            aproduct._ready = true;
                                        }
                                    }
                                }

                                if (!aproduct._ready)
                                {
                                    throw new Exception("Invalid Code");
                                }

                                if (product.IsSetSalesRankings())
                                {
                                    var salesRanks = product.SalesRankings;

                                    if (product.IsSetSalesRankings())
                                    {
                                        var ranks = salesRanks.SalesRank;

                                        aproduct.SalesRanks = new List<SalesRank>();

                                        foreach (var rank in ranks)
                                        {
                                            if (rank.IsSetProductCategoryId() && rank.IsSetRank())
                                            {
                                                aproduct.SalesRanks.Add(new SalesRank() { Category = rank.ProductCategoryId, Rank = rank.Rank });
                                            }
                                        }
                                    }
                                }

                                if (product.IsSetAttributeSets())
                                {
                                    var attributes = product.AttributeSets;

                                    var x = product.ToXMLFragment();
                                    var xml = XDocument.Parse("<product>" + x.Replace("ns2:", "") + "</product>");
                                    var query = from attr in xml.Descendants("SmallImage")
                                                from img in attr.Elements()
                                                where img.Name == "URL"
                                                select img.Value;
                                    aproduct.Image = new Uri(query.Single());

                                    var titq = from attr in xml.Descendants()
                                               where attr.Name == "Title"
                                               select attr.Value;
                                    aproduct.Title = titq.Single();

                                    var authq = from attr in xml.Descendants()
                                                where attr.Name == "Author"
                                                select attr.Value;
                                    aproduct.Author = authq.FirstOrDefault();

                                    var artistq = from attr in xml.Descendants()
                                                  where attr.Name == "Artist"
                                                  select attr.Value;
                                    aproduct.Artist = artistq.FirstOrDefault();

                                    var director = from a in xml.Descendants()
                                                   where a.Name == "Director"
                                                   select a.Value;
                                    aproduct.Director = director.FirstOrDefault();

                                    var bindingq = from attr in xml.Descendants()
                                                   where attr.Name == "Binding"
                                                   select attr.Value;
                                    aproduct.Binding = bindingq.FirstOrDefault();

                                    var editionq = from attr in xml.Descendants()
                                                   where attr.Name == "Edition"
                                                   select attr.Value;
                                    aproduct.Edition = editionq.FirstOrDefault();

                                    var heightq = from a in xml.Descendants("PackageDimensions")
                                                  from i in a.Elements()
                                                  where i.Name == "Height"
                                                  select new { value = i.Value, metric = i.FirstAttribute.Value };
                                    aproduct.Height = ConvertToMetrics(heightq.FirstOrDefault());

                                    var lenq = from a in xml.Descendants("PackageDimensions")
                                               from i in a.Elements()
                                               where i.Name == "Length"
                                               select new { value = i.Value, metric = i.FirstAttribute.Value };
                                    aproduct.Length = ConvertToMetrics(lenq.FirstOrDefault());

                                    var widq = from a in xml.Descendants("PackageDimensions")
                                               from i in a.Elements()
                                               where i.Name == "Width"
                                               select new { value = i.Value, metric = i.FirstAttribute.Value };
                                    aproduct.Width = ConvertToMetrics(widq.FirstOrDefault());

                                    var weight = from a in xml.Descendants("PackageDimensions")
                                                 from i in a.Elements()
                                                 where i.Name == "Weight"
                                                 select new { value = i.Value, metric = i.FirstAttribute.Value };
                                    aproduct.Weight = ConvertToMetrics(weight.FirstOrDefault());

                                    var price = from a in xml.Descendants("ListPrice")
                                                from i in a.Elements()
                                                where i.Name == "Amount"
                                                select i.Value;
                                    if (price.FirstOrDefault() != null)
                                    {
                                        aproduct.ListPrice = decimal.Parse(price.FirstOrDefault());
                                    }

                                    var cc = from a in xml.Descendants("ListPrice")
                                             from i in a.Elements()
                                             where i.Name == "CurrencyCode"
                                             select i.Value;
                                    aproduct.CurrencyCode = cc.FirstOrDefault();

                                    var man = from a in xml.Descendants()
                                              where a.Name == "Manufacturer"
                                              select a.Value;
                                    aproduct.Manufacturer = man.FirstOrDefault();

                                    var group = from a in xml.Descendants()
                                                where a.Name == "ProductGroup"
                                                select a.Value;
                                    aproduct.Group = group.FirstOrDefault();

                                    AProducts.Add(aproduct);
                                }
                            }
                        }
                    }
                }
            }

            return AProducts;
        }

        /// <summary>
        /// Converts measurement data to the metric system
        /// </summary>
        /// <param name="measurements"></param>
        /// <returns></returns>
        private decimal ConvertToMetrics(dynamic measurements)
        {
            if (measurements == null) return 0;

            decimal value = decimal.Parse(measurements.value);

            if (measurements.metric == "inches")
            {
                return value * 2.54M;
            }

            if (measurements.metric == "pounds")
            {
                return value * 0.453592M;
            }

            return value;
        }
    }
}