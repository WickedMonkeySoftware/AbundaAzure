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

        internal bool _ready;

        public Dictionary<string, decimal> SalesRanks
        {
            get;
            set;
        }

        public Uri Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Artist { get; set; }
        public string Binding { get; set; }
        public string Edition { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Weight { get; set; }
        public decimal ListPrice { get; set; }
        public string CurrencyCode { get; set; }
        public string Manufacturer { get; set; }
        public string Group { get; set; }
        public string Director { get; set; }

        public string Code
        {
            get
            {
                return this.RowKey;
            }
            set
            {
                this.RowKey = value;
            }
        }
        public string ASIN
        {
            get
            {
                return this.PartitionKey;
            }
            set
            {
                this.PartitionKey = value;
            }
        }
    }
}