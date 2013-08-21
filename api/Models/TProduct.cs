using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure;
using MarketplaceWebServiceProducts;

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

        public TProduct(string code, int qty)
        {
            ProductCode = code;
            Qty = qty;

            cloud = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("AbundaStorage"));

            client = cloud.CreateCloudTableClient();

            products = client.GetTableReference("Products");
            products.CreateIfNotExists();
        }

        public void PerformAmazonLookup()
        {

        }
    }
}