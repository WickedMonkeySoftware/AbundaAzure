/******************************************************************************* 
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service Products CSharp Library
 *  API Version: 2011-10-01
 * 
 */


using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using MarketplaceWebServiceProducts;
using MarketplaceWebServiceProducts.Model;



namespace MarketplaceWebServiceProducts.Samples
{

    /// <summary>
    /// Get Lowest Offer Listings For SKU  Samples
    /// </summary>
    public class GetLowestOfferListingsForSKUSample
    {
    
                                                                 
        /// <summary>
        /// Gets some of the lowest prices based on the product identified by the given
        /// SellerId and SKU.
        /// 
        /// </summary>
        /// <param name="service">Instance of MarketplaceWebServiceProducts service</param>
        /// <param name="request">GetLowestOfferListingsForSKURequest request</param>
        public static void InvokeGetLowestOfferListingsForSKU(MarketplaceWebServiceProducts service, GetLowestOfferListingsForSKURequest request)
        {
            try 
            {
                GetLowestOfferListingsForSKUResponse response = service.GetLowestOfferListingsForSKU(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetLowestOfferListingsForSKUResponse");
                List<GetLowestOfferListingsForSKUResult> getLowestOfferListingsForSKUResultList = response.GetLowestOfferListingsForSKUResult;
                foreach (GetLowestOfferListingsForSKUResult getLowestOfferListingsForSKUResult in getLowestOfferListingsForSKUResultList)
                {
                    Console.WriteLine("            GetLowestOfferListingsForSKUResult");
                if (getLowestOfferListingsForSKUResult.IsSetSellerSKU()) {
                    Console.WriteLine("        SellerSKU");
                    Console.WriteLine();
                    Console.WriteLine("                {0}",  getLowestOfferListingsForSKUResult.SellerSKU);
                    Console.WriteLine();
                } 
                if (getLowestOfferListingsForSKUResult.IsSetstatus()) {
                    Console.WriteLine("        status");
                    Console.WriteLine();
                    Console.WriteLine("                {0}",  getLowestOfferListingsForSKUResult.status);
                    Console.WriteLine();
                } 
                    if (getLowestOfferListingsForSKUResult.IsSetAllOfferListingsConsidered())
                    {
                        Console.WriteLine("                AllOfferListingsConsidered");
                        Console.WriteLine("                    {0}", getLowestOfferListingsForSKUResult.AllOfferListingsConsidered);
                    }
                    if (getLowestOfferListingsForSKUResult.IsSetProduct())
                    {
                        Console.WriteLine("                Product");
                        Product  product = getLowestOfferListingsForSKUResult.Product;
                        if (product.IsSetIdentifiers())
                        {
                            Console.WriteLine("                    Identifiers");
                            IdentifierType  identifiers = product.Identifiers;
                            if (identifiers.IsSetMarketplaceASIN())
                            {
                                Console.WriteLine("                        MarketplaceASIN");
                                ASINIdentifier  marketplaceASIN = identifiers.MarketplaceASIN;
                                if (marketplaceASIN.IsSetMarketplaceId())
                                {
                                    Console.WriteLine("                            MarketplaceId");
                                    Console.WriteLine("                                {0}", marketplaceASIN.MarketplaceId);
                                }
                                if (marketplaceASIN.IsSetASIN())
                                {
                                    Console.WriteLine("                            ASIN");
                                    Console.WriteLine("                                {0}", marketplaceASIN.ASIN);
                                }
                            }
                            if (identifiers.IsSetSKUIdentifier())
                            {
                                Console.WriteLine("                        SKUIdentifier");
                                SellerSKUIdentifier  SKUIdentifier = identifiers.SKUIdentifier;
                                if (SKUIdentifier.IsSetMarketplaceId())
                                {
                                    Console.WriteLine("                            MarketplaceId");
                                    Console.WriteLine("                                {0}", SKUIdentifier.MarketplaceId);
                                }
                                if (SKUIdentifier.IsSetSellerId())
                                {
                                    Console.WriteLine("                            SellerId");
                                    Console.WriteLine("                                {0}", SKUIdentifier.SellerId);
                                }
                                if (SKUIdentifier.IsSetSellerSKU())
                                {
                                    Console.WriteLine("                            SellerSKU");
                                    Console.WriteLine("                                {0}", SKUIdentifier.SellerSKU);
                                }
                            }
                        }
                        if (product.IsSetCompetitivePricing())
                        {
                            Console.WriteLine("                    CompetitivePricing");
                            CompetitivePricingType  competitivePricing = product.CompetitivePricing;
                            if (competitivePricing.IsSetCompetitivePrices())
                            {
                                Console.WriteLine("                        CompetitivePrices");
                                CompetitivePriceList  competitivePrices = competitivePricing.CompetitivePrices;
                                List<CompetitivePriceType> competitivePriceList = competitivePrices.CompetitivePrice;
                                foreach (CompetitivePriceType competitivePrice in competitivePriceList)
                                {
                                    Console.WriteLine("                            CompetitivePrice");
                                if (competitivePrice.IsSetcondition()) {
                                    Console.WriteLine("                        condition");
                                    Console.WriteLine();
                                    Console.WriteLine("                                {0}",  competitivePrice.condition);
                                    Console.WriteLine();
                                } 
                                if (competitivePrice.IsSetsubcondition()) {
                                    Console.WriteLine("                        subcondition");
                                    Console.WriteLine();
                                    Console.WriteLine("                                {0}",  competitivePrice.subcondition);
                                    Console.WriteLine();
                                } 
                                if (competitivePrice.IsSetbelongsToRequester()) {
                                    Console.WriteLine("                        belongsToRequester");
                                    Console.WriteLine();
                                    Console.WriteLine("                                {0}",  competitivePrice.belongsToRequester);
                                    Console.WriteLine();
                                } 
                                    if (competitivePrice.IsSetCompetitivePriceId())
                                    {
                                        Console.WriteLine("                                CompetitivePriceId");
                                        Console.WriteLine("                                    {0}", competitivePrice.CompetitivePriceId);
                                    }
                                    if (competitivePrice.IsSetPrice())
                                    {
                                        Console.WriteLine("                                Price");
                                        PriceType  price = competitivePrice.Price;
                                        if (price.IsSetLandedPrice())
                                        {
                                            Console.WriteLine("                                    LandedPrice");
                                            MoneyType  landedPrice = price.LandedPrice;
                                            if (landedPrice.IsSetCurrencyCode())
                                            {
                                                Console.WriteLine("                                        CurrencyCode");
                                                Console.WriteLine("                                            {0}", landedPrice.CurrencyCode);
                                            }
                                            if (landedPrice.IsSetAmount())
                                            {
                                                Console.WriteLine("                                        Amount");
                                                Console.WriteLine("                                            {0}", landedPrice.Amount);
                                            }
                                        }
                                        if (price.IsSetListingPrice())
                                        {
                                            Console.WriteLine("                                    ListingPrice");
                                            MoneyType  listingPrice = price.ListingPrice;
                                            if (listingPrice.IsSetCurrencyCode())
                                            {
                                                Console.WriteLine("                                        CurrencyCode");
                                                Console.WriteLine("                                            {0}", listingPrice.CurrencyCode);
                                            }
                                            if (listingPrice.IsSetAmount())
                                            {
                                                Console.WriteLine("                                        Amount");
                                                Console.WriteLine("                                            {0}", listingPrice.Amount);
                                            }
                                        }
                                        if (price.IsSetShipping())
                                        {
                                            Console.WriteLine("                                    Shipping");
                                            MoneyType  shipping = price.Shipping;
                                            if (shipping.IsSetCurrencyCode())
                                            {
                                                Console.WriteLine("                                        CurrencyCode");
                                                Console.WriteLine("                                            {0}", shipping.CurrencyCode);
                                            }
                                            if (shipping.IsSetAmount())
                                            {
                                                Console.WriteLine("                                        Amount");
                                                Console.WriteLine("                                            {0}", shipping.Amount);
                                            }
                                        }
                                    }
                                }
                            }
                            if (competitivePricing.IsSetNumberOfOfferListings())
                            {
                                Console.WriteLine("                        NumberOfOfferListings");
                                NumberOfOfferListingsList  numberOfOfferListings = competitivePricing.NumberOfOfferListings;
                                List<OfferListingCountType> offerListingCountList = numberOfOfferListings.OfferListingCount;
                                foreach (OfferListingCountType offerListingCount in offerListingCountList)
                                {
                                    Console.WriteLine("                            OfferListingCount");
                                if (offerListingCount.IsSetcondition()) {
                                    Console.WriteLine("                        condition");
                                    Console.WriteLine();
                                    Console.WriteLine("                                {0}",  offerListingCount.condition);
                                    Console.WriteLine();
                                } 
                                if (offerListingCount.IsSetValue()) {
                                    Console.WriteLine("                        Value");
                                    Console.WriteLine();
                                    Console.WriteLine("                                {0}",  offerListingCount.Value);
                                } 
                                }
                            }
                            if (competitivePricing.IsSetTradeInValue())
                            {
                                Console.WriteLine("                        TradeInValue");
                                MoneyType  tradeInValue = competitivePricing.TradeInValue;
                                if (tradeInValue.IsSetCurrencyCode())
                                {
                                    Console.WriteLine("                            CurrencyCode");
                                    Console.WriteLine("                                {0}", tradeInValue.CurrencyCode);
                                }
                                if (tradeInValue.IsSetAmount())
                                {
                                    Console.WriteLine("                            Amount");
                                    Console.WriteLine("                                {0}", tradeInValue.Amount);
                                }
                            }
                        }
                        if (product.IsSetSalesRankings())
                        {
                            Console.WriteLine("                    SalesRankings");
                            SalesRankList  salesRankings = product.SalesRankings;
                            List<SalesRankType> salesRankList = salesRankings.SalesRank;
                            foreach (SalesRankType salesRank in salesRankList)
                            {
                                Console.WriteLine("                        SalesRank");
                                if (salesRank.IsSetProductCategoryId())
                                {
                                    Console.WriteLine("                            ProductCategoryId");
                                    Console.WriteLine("                                {0}", salesRank.ProductCategoryId);
                                }
                                if (salesRank.IsSetRank())
                                {
                                    Console.WriteLine("                            Rank");
                                    Console.WriteLine("                                {0}", salesRank.Rank);
                                }
                            }
                        }
                        if (product.IsSetLowestOfferListings())
                        {
                            Console.WriteLine("                    LowestOfferListings");
                            LowestOfferListingList  lowestOfferListings = product.LowestOfferListings;
                            List<LowestOfferListingType> lowestOfferListingList = lowestOfferListings.LowestOfferListing;
                            foreach (LowestOfferListingType lowestOfferListing in lowestOfferListingList)
                            {
                                Console.WriteLine("                        LowestOfferListing");
                                if (lowestOfferListing.IsSetQualifiers())
                                {
                                    Console.WriteLine("                            Qualifiers");
                                    QualifiersType  qualifiers = lowestOfferListing.Qualifiers;
                                    if (qualifiers.IsSetItemCondition())
                                    {
                                        Console.WriteLine("                                ItemCondition");
                                        Console.WriteLine("                                    {0}", qualifiers.ItemCondition);
                                    }
                                    if (qualifiers.IsSetItemSubcondition())
                                    {
                                        Console.WriteLine("                                ItemSubcondition");
                                        Console.WriteLine("                                    {0}", qualifiers.ItemSubcondition);
                                    }
                                    if (qualifiers.IsSetFulfillmentChannel())
                                    {
                                        Console.WriteLine("                                FulfillmentChannel");
                                        Console.WriteLine("                                    {0}", qualifiers.FulfillmentChannel);
                                    }
                                    if (qualifiers.IsSetShipsDomestically())
                                    {
                                        Console.WriteLine("                                ShipsDomestically");
                                        Console.WriteLine("                                    {0}", qualifiers.ShipsDomestically);
                                    }
                                    if (qualifiers.IsSetShippingTime())
                                    {
                                        Console.WriteLine("                                ShippingTime");
                                        ShippingTimeType  shippingTime = qualifiers.ShippingTime;
                                        if (shippingTime.IsSetMax())
                                        {
                                            Console.WriteLine("                                    Max");
                                            Console.WriteLine("                                        {0}", shippingTime.Max);
                                        }
                                    }
                                    if (qualifiers.IsSetSellerPositiveFeedbackRating())
                                    {
                                        Console.WriteLine("                                SellerPositiveFeedbackRating");
                                        Console.WriteLine("                                    {0}", qualifiers.SellerPositiveFeedbackRating);
                                    }
                                }
                                if (lowestOfferListing.IsSetNumberOfOfferListingsConsidered())
                                {
                                    Console.WriteLine("                            NumberOfOfferListingsConsidered");
                                    Console.WriteLine("                                {0}", lowestOfferListing.NumberOfOfferListingsConsidered);
                                }
                                if (lowestOfferListing.IsSetSellerFeedbackCount())
                                {
                                    Console.WriteLine("                            SellerFeedbackCount");
                                    Console.WriteLine("                                {0}", lowestOfferListing.SellerFeedbackCount);
                                }
                                if (lowestOfferListing.IsSetPrice())
                                {
                                    Console.WriteLine("                            Price");
                                    PriceType  price1 = lowestOfferListing.Price;
                                    if (price1.IsSetLandedPrice())
                                    {
                                        Console.WriteLine("                                LandedPrice");
                                        MoneyType  landedPrice1 = price1.LandedPrice;
                                        if (landedPrice1.IsSetCurrencyCode())
                                        {
                                            Console.WriteLine("                                    CurrencyCode");
                                            Console.WriteLine("                                        {0}", landedPrice1.CurrencyCode);
                                        }
                                        if (landedPrice1.IsSetAmount())
                                        {
                                            Console.WriteLine("                                    Amount");
                                            Console.WriteLine("                                        {0}", landedPrice1.Amount);
                                        }
                                    }
                                    if (price1.IsSetListingPrice())
                                    {
                                        Console.WriteLine("                                ListingPrice");
                                        MoneyType  listingPrice1 = price1.ListingPrice;
                                        if (listingPrice1.IsSetCurrencyCode())
                                        {
                                            Console.WriteLine("                                    CurrencyCode");
                                            Console.WriteLine("                                        {0}", listingPrice1.CurrencyCode);
                                        }
                                        if (listingPrice1.IsSetAmount())
                                        {
                                            Console.WriteLine("                                    Amount");
                                            Console.WriteLine("                                        {0}", listingPrice1.Amount);
                                        }
                                    }
                                    if (price1.IsSetShipping())
                                    {
                                        Console.WriteLine("                                Shipping");
                                        MoneyType  shipping1 = price1.Shipping;
                                        if (shipping1.IsSetCurrencyCode())
                                        {
                                            Console.WriteLine("                                    CurrencyCode");
                                            Console.WriteLine("                                        {0}", shipping1.CurrencyCode);
                                        }
                                        if (shipping1.IsSetAmount())
                                        {
                                            Console.WriteLine("                                    Amount");
                                            Console.WriteLine("                                        {0}", shipping1.Amount);
                                        }
                                    }
                                }
                                if (lowestOfferListing.IsSetMultipleOffersAtLowestPrice())
                                {
                                    Console.WriteLine("                            MultipleOffersAtLowestPrice");
                                    Console.WriteLine("                                {0}", lowestOfferListing.MultipleOffersAtLowestPrice);
                                }
                            }
                        }
                        if (product.IsSetOffers())
                        {
                            Console.WriteLine("                    Offers");
                            OffersList  offers = product.Offers;
                            List<OfferType> offerList = offers.Offer;
                            foreach (OfferType offer in offerList)
                            {
                                Console.WriteLine("                        Offer");
                                if (offer.IsSetBuyingPrice())
                                {
                                    Console.WriteLine("                            BuyingPrice");
                                    PriceType  buyingPrice = offer.BuyingPrice;
                                    if (buyingPrice.IsSetLandedPrice())
                                    {
                                        Console.WriteLine("                                LandedPrice");
                                        MoneyType  landedPrice2 = buyingPrice.LandedPrice;
                                        if (landedPrice2.IsSetCurrencyCode())
                                        {
                                            Console.WriteLine("                                    CurrencyCode");
                                            Console.WriteLine("                                        {0}", landedPrice2.CurrencyCode);
                                        }
                                        if (landedPrice2.IsSetAmount())
                                        {
                                            Console.WriteLine("                                    Amount");
                                            Console.WriteLine("                                        {0}", landedPrice2.Amount);
                                        }
                                    }
                                    if (buyingPrice.IsSetListingPrice())
                                    {
                                        Console.WriteLine("                                ListingPrice");
                                        MoneyType  listingPrice2 = buyingPrice.ListingPrice;
                                        if (listingPrice2.IsSetCurrencyCode())
                                        {
                                            Console.WriteLine("                                    CurrencyCode");
                                            Console.WriteLine("                                        {0}", listingPrice2.CurrencyCode);
                                        }
                                        if (listingPrice2.IsSetAmount())
                                        {
                                            Console.WriteLine("                                    Amount");
                                            Console.WriteLine("                                        {0}", listingPrice2.Amount);
                                        }
                                    }
                                    if (buyingPrice.IsSetShipping())
                                    {
                                        Console.WriteLine("                                Shipping");
                                        MoneyType  shipping2 = buyingPrice.Shipping;
                                        if (shipping2.IsSetCurrencyCode())
                                        {
                                            Console.WriteLine("                                    CurrencyCode");
                                            Console.WriteLine("                                        {0}", shipping2.CurrencyCode);
                                        }
                                        if (shipping2.IsSetAmount())
                                        {
                                            Console.WriteLine("                                    Amount");
                                            Console.WriteLine("                                        {0}", shipping2.Amount);
                                        }
                                    }
                                }
                                if (offer.IsSetRegularPrice())
                                {
                                    Console.WriteLine("                            RegularPrice");
                                    MoneyType  regularPrice = offer.RegularPrice;
                                    if (regularPrice.IsSetCurrencyCode())
                                    {
                                        Console.WriteLine("                                CurrencyCode");
                                        Console.WriteLine("                                    {0}", regularPrice.CurrencyCode);
                                    }
                                    if (regularPrice.IsSetAmount())
                                    {
                                        Console.WriteLine("                                Amount");
                                        Console.WriteLine("                                    {0}", regularPrice.Amount);
                                    }
                                }
                                if (offer.IsSetFulfillmentChannel())
                                {
                                    Console.WriteLine("                            FulfillmentChannel");
                                    Console.WriteLine("                                {0}", offer.FulfillmentChannel);
                                }
                                if (offer.IsSetItemCondition())
                                {
                                    Console.WriteLine("                            ItemCondition");
                                    Console.WriteLine("                                {0}", offer.ItemCondition);
                                }
                                if (offer.IsSetItemSubCondition())
                                {
                                    Console.WriteLine("                            ItemSubCondition");
                                    Console.WriteLine("                                {0}", offer.ItemSubCondition);
                                }
                                if (offer.IsSetSellerId())
                                {
                                    Console.WriteLine("                            SellerId");
                                    Console.WriteLine("                                {0}", offer.SellerId);
                                }
                                if (offer.IsSetSellerSKU())
                                {
                                    Console.WriteLine("                            SellerSKU");
                                    Console.WriteLine("                                {0}", offer.SellerSKU);
                                }
                            }
                        }
                    }
                    if (getLowestOfferListingsForSKUResult.IsSetError())
                    {
                        Console.WriteLine("                Error");
                        Error  error = getLowestOfferListingsForSKUResult.Error;
                        if (error.IsSetType())
                        {
                            Console.WriteLine("                    Type");
                            Console.WriteLine("                        {0}", error.Type);
                        }
                        if (error.IsSetCode())
                        {
                            Console.WriteLine("                    Code");
                            Console.WriteLine("                        {0}", error.Code);
                        }
                        if (error.IsSetMessage())
                        {
                            Console.WriteLine("                    Message");
                            Console.WriteLine("                        {0}", error.Message);
                        }
                    }
                }
                if (response.IsSetResponseMetadata())
                {
                    Console.WriteLine("            ResponseMetadata");
                    ResponseMetadata  responseMetadata = response.ResponseMetadata;
                    if (responseMetadata.IsSetRequestId())
                    {
                        Console.WriteLine("                RequestId");
                        Console.WriteLine("                    {0}", responseMetadata.RequestId);
                    }
                }
                Console.WriteLine("            ResponseHeaderMetadata");
                Console.WriteLine("                RequestId");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.RequestId);
                Console.WriteLine("                ResponseContext");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.ResponseContext);
                Console.WriteLine("                Timestamp");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.Timestamp);
                Console.WriteLine();


            } 
            catch (MarketplaceWebServiceProductsException ex) 
            {
                Console.WriteLine("Caught Exception: " + ex.Message);
                Console.WriteLine("Response Status Code: " + ex.StatusCode);
                Console.WriteLine("Error Code: " + ex.ErrorCode);
                Console.WriteLine("Error Type: " + ex.ErrorType);
                Console.WriteLine("Request ID: " + ex.RequestId);
                Console.WriteLine("XML: " + ex.XML);
                Console.WriteLine("ResponseHeaderMetadata: " + ex.ResponseHeaderMetadata);
            }
        }
            }
}
