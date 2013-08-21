using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure;

namespace api.Models
{
    public class AmazonProduct : TableEntity
    {
        public AmazonProduct(string code, string asin)
        {
            this.PartitionKey = asin;
            this.RowKey = code;
        }

        public AmazonProduct()
        {
        }

        public string Code { get; set; }
        public string ASIN { get; set; }
    }
}