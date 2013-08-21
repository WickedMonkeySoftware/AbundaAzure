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
using MarketplaceWebServiceProducts.Model;

namespace MarketplaceWebServiceProducts
{




    /// <summary>
    /// This is the Products API section of the Marketplace Web Service.
    /// 
    /// </summary>
    public interface MarketplaceWebServiceProducts
    {
                
        /// <summary>
        /// Get Matching Product 
        /// </summary>
        /// <param name="request">Get Matching Product  request</param>
        /// <returns>Get Matching Product  Response from the service</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given ASIN.
        ///   
        /// </remarks>
        GetMatchingProductResponse GetMatchingProduct(GetMatchingProductRequest request);

                
        /// <summary>
        /// Get Lowest Offer Listings For ASIN 
        /// </summary>
        /// <param name="request">Get Lowest Offer Listings For ASIN  request</param>
        /// <returns>Get Lowest Offer Listings For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets some of the lowest prices based on the product identified by the given
        /// MarketplaceId and ASIN.
        ///   
        /// </remarks>
        GetLowestOfferListingsForASINResponse GetLowestOfferListingsForASIN(GetLowestOfferListingsForASINRequest request);

                
        /// <summary>
        /// Get Service Status 
        /// </summary>
        /// <param name="request">Get Service Status  request</param>
        /// <returns>Get Service Status  Response from the service</returns>
        /// <remarks>
        /// Returns the service status of a particular MWS API section. The operation
        /// takes no input.
        /// All API sections within the API are required to implement this operation.
        ///   
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

                
        /// <summary>
        /// Get Matching Product For Id 
        /// </summary>
        /// <param name="request">Get Matching Product For Id  request</param>
        /// <returns>Get Matching Product For Id  Response from the service</returns>
        /// <remarks>
        /// GetMatchingProductForId will return the details (attributes) for the
        /// given Identifier list. Identifer type can be one of [SKU|ASIN|UPC|EAN|ISBN|GTIN|JAN]
        ///   
        /// </remarks>
        GetMatchingProductForIdResponse GetMatchingProductForId(GetMatchingProductForIdRequest request);

                
        /// <summary>
        /// Get My Price For SKU 
        /// </summary>
        /// <param name="request">Get My Price For SKU  request</param>
        /// <returns>Get My Price For SKU  Response from the service</returns>
        /// <remarks>
        ///   
        /// </remarks>
        GetMyPriceForSKUResponse GetMyPriceForSKU(GetMyPriceForSKURequest request);

                
        /// <summary>
        /// List Matching Products 
        /// </summary>
        /// <param name="request">List Matching Products  request</param>
        /// <returns>List Matching Products  Response from the service</returns>
        /// <remarks>
        /// ListMatchingProducts can be used to
        /// find products that match the given criteria.
        ///   
        /// </remarks>
        ListMatchingProductsResponse ListMatchingProducts(ListMatchingProductsRequest request);

                
        /// <summary>
        /// Get Competitive Pricing For SKU 
        /// </summary>
        /// <param name="request">Get Competitive Pricing For SKU  request</param>
        /// <returns>Get Competitive Pricing For SKU  Response from the service</returns>
        /// <remarks>
        /// Gets competitive pricing and related information for a product identified by
        /// the SellerId and SKU.
        ///   
        /// </remarks>
        GetCompetitivePricingForSKUResponse GetCompetitivePricingForSKU(GetCompetitivePricingForSKURequest request);

                
        /// <summary>
        /// Get Competitive Pricing For ASIN 
        /// </summary>
        /// <param name="request">Get Competitive Pricing For ASIN  request</param>
        /// <returns>Get Competitive Pricing For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets competitive pricing and related information for a product identified by
        /// the MarketplaceId and ASIN.
        ///   
        /// </remarks>
        GetCompetitivePricingForASINResponse GetCompetitivePricingForASIN(GetCompetitivePricingForASINRequest request);

                
        /// <summary>
        /// Get Product Categories For SKU 
        /// </summary>
        /// <param name="request">Get Product Categories For SKU  request</param>
        /// <returns>Get Product Categories For SKU  Response from the service</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the SellerId and SKU.
        ///   
        /// </remarks>
        GetProductCategoriesForSKUResponse GetProductCategoriesForSKU(GetProductCategoriesForSKURequest request);

                
        /// <summary>
        /// Get My Price For ASIN 
        /// </summary>
        /// <param name="request">Get My Price For ASIN  request</param>
        /// <returns>Get My Price For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the SellerId and SKU.
        ///   
        /// </remarks>
        GetMyPriceForASINResponse GetMyPriceForASIN(GetMyPriceForASINRequest request);

                
        /// <summary>
        /// Get Lowest Offer Listings For SKU 
        /// </summary>
        /// <param name="request">Get Lowest Offer Listings For SKU  request</param>
        /// <returns>Get Lowest Offer Listings For SKU  Response from the service</returns>
        /// <remarks>
        /// Gets some of the lowest prices based on the product identified by the given
        /// SellerId and SKU.
        ///   
        /// </remarks>
        GetLowestOfferListingsForSKUResponse GetLowestOfferListingsForSKU(GetLowestOfferListingsForSKURequest request);

                
        /// <summary>
        /// Get Product Categories For ASIN 
        /// </summary>
        /// <param name="request">Get Product Categories For ASIN  request</param>
        /// <returns>Get Product Categories For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the MarketplaceId and ASIN.
        ///   
        /// </remarks>
        GetProductCategoriesForASINResponse GetProductCategoriesForASIN(GetProductCategoriesForASINRequest request);

    }
}
