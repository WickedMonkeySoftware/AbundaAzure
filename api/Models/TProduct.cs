using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure;
using System.Xml;
using System.Xml.Linq;

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

        public TProduct(string affiliate, string code, int qty, bool force_lookup = false)
        {
            ProductCode = code;
            Qty = qty;

            cloud = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("AbundaStorage"));

            client = cloud.CreateCloudTableClient();

            products = client.GetTableReference("Products");
            products.CreateIfNotExists();

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
        }

        public List<AmazonProduct> PerformAmazonLookup()
        {
            MarketplaceWebServiceProducts.MarketplaceWebServiceProductsConfig config = new MarketplaceWebServiceProducts.MarketplaceWebServiceProductsConfig();
            config.ServiceURL = "https://mws.amazonservices.com";
            MarketplaceWebServiceProducts.MarketplaceWebServiceProductsClient client = new MarketplaceWebServiceProducts.MarketplaceWebServiceProductsClient("Abundatrade.com", "2.0", accessKey, secretKey, config);

            List<AmazonProduct> AProducts = new List<AmazonProduct>();

            var id_request = new MarketplaceWebServiceProducts.Model.GetMatchingProductForIdRequest();
            id_request.IdList = new MarketplaceWebServiceProducts.Model.IdListType();
            id_request.IdList.Id = new List<string>();
            id_request.IdList.Id.Add(ProductCode);
            id_request.IdType = "UPC";
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

                                        aproduct.SalesRanks = new Dictionary<string,decimal>();

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

                                    var bindingq = from attr in xml.Descendants()
                                                   where attr.Name == "Binding"
                                                   select attr.Value;
                                    aproduct.Binding = bindingq.FirstOrDefault();

                                    var editionq = from attr in xml.Descendants()
                                                   where attr.Name == "Edition"
                                                   select attr.Value;
                                    aproduct.Edition = editionq.FirstOrDefault();

                                    var heightq = from a in xml.Descendants("ItemDimensions")
                                                  where a.Name == "Height"
                                                  select new { value = a.Value, metric = a.FirstAttribute.Value };
                                    aproduct.Height = ConvertToMetrics(heightq.FirstOrDefault());

                                    var lenq = from a in xml.Descendants("ItemDimensions")
                                               where a.Name == "Length"
                                               select new { value = a.Value, metric = a.FirstAttribute.Value };
                                    aproduct.Length = ConvertToMetrics(lenq.FirstOrDefault());

                                    var widq = from a in xml.Descendants("ItemDimensions")
                                               where a.Name == "Width"
                                               select new { value = a.Value, metric = a.FirstAttribute.Value };
                                    aproduct.Width = ConvertToMetrics(widq.FirstOrDefault());

                                    var weight = from a in xml.Descendants("ItemDimensions")
                                                 where a.Name == "Weight"
                                                 select new { value = a.Value, metric = a.FirstAttribute.Value };
                                    aproduct.Weight = ConvertToMetrics(weight.FirstOrDefault());

                                    var price = from a in xml.Descendants("ListPrice")
                                                where a.Name == "Amount"
                                                select a.Value;
                                    aproduct.ListPrice = decimal.Parse(price.FirstOrDefault());

                                    var cc = from a in xml.Descendants("ListPrice")
                                                where a.Name == "CurrencyCode"
                                                select a.Value;
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

        private decimal ConvertToMetrics(dynamic measurements)
        {
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