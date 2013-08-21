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
        public TProduct(string affiliate, string code, int qty, bool force_lookup = false)
        {
            ProductCode = code;
            Qty = qty;

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

            //todo: figure out the real product here

            if (amzResults.Count == 0)
            {
                CalculatorView = new { error = "Unknown Item, double check your search" };
                return;
            }

            //todo: finish looking up the real product

            //todo: save data in cache

            //todo: save data for retrieval in a list

            CalculatorView = new
            {
                currency_for_total="$",
                id = "0",
                image = "small",
                imagem = "medium",
                imagel = "large",
                price = amzResults[0].ListPrice,
                product_code = amzResults[0].Code,
                quantity = qty,
                title = amzResults[0].Title,
                total = amzResults[0].ListPrice * qty,
                total_qty = qty,
                row = new List<dynamic>()
            };

            CalculatorView.row.Add(new { testrow = "data" });
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
            MarketplaceWebServiceProducts.MarketplaceWebServiceProductsClient client = new MarketplaceWebServiceProducts.MarketplaceWebServiceProductsClient("Abundatrade.com", "2.0", accessKey, secretKey, config);

            List<AmazonProduct> AProducts = new List<AmazonProduct>();

            var id_request = new MarketplaceWebServiceProducts.Model.GetMatchingProductForIdRequest();
            id_request.IdList = new MarketplaceWebServiceProducts.Model.IdListType();
            id_request.IdList.Id = new List<string>();
            id_request.IdList.Id.Add(ProductCode);
            id_request.IdType = CodeType(ProductCode);
            id_request.SellerId = merchantID;
            id_request.MarketplaceId = marketplaceID;

            var id_result = client.GetMatchingProductForId(id_request);

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

                                        aproduct.SalesRanks = new Dictionary<string, decimal>();

                                        foreach (var rank in ranks)
                                        {
                                            if (rank.IsSetProductCategoryId() && rank.IsSetRank())
                                            {
                                                aproduct.SalesRanks.Add(rank.ProductCategoryId, rank.Rank);
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
                                    aproduct.ListPrice = decimal.Parse(price.FirstOrDefault());

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