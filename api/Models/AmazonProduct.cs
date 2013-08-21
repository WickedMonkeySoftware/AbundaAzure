using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure;

namespace api.Models
{
    public class PriceType
    {
        public decimal LandedPrice;
        public decimal Shipping;
        public decimal ListPrice;
    }

    public enum TriBool
    {
        False = 0,
        True = 1,
        Unknown = -1
    }

    public class ConditionList
    {
        public string Condition { get; set; }
        public string SubCondition { get; set; }
        public PriceType Price { get; set; }
        public decimal Count { get; set; }
    }

    public class OfferListing
    {
        public decimal NumberOfferListings { get; set; }
        public decimal SellerFeedbackCount { get; set; }
        public PriceType Price { get; set; }
        public TriBool MultipleOffersAtPrice { get; set; }
        public string Condition { get; set; }
        public string SubCondition { get; set; }
        public string Fullfillment { get; set; }
        public TriBool ShipsDomestically { get; set; }
        public string ShippingTime { get; set; }
        public string PositiveFeedbackSetting { get; set; }
    }

    public class SalesRank
    {
        public string Category { get; set; }
        public decimal Rank { get; set; }
    }

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

        #region Lowest Offer Listings

        public bool AllOfferListingsUsed { get; set; }
        public List<OfferListing> LowestOfferListing { get; set; }

        #endregion

        #region Competitive Pricing

        public List<ConditionList> CompetivePrices { get; set; }
        public List<ConditionList> OfferListingCount { get; set; }
        public decimal TradeInValue { get; set; }

        #endregion

        #region GetMatchingID

        public List<SalesRank> SalesRanks
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

        #endregion
    }
}