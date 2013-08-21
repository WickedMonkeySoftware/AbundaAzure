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
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using MarketplaceWebServiceProducts.Model;

namespace MarketplaceWebServiceProducts.Mock
{

    /// <summary>
    /// MarketplaceWebServiceProductsMock is the implementation of MarketplaceWebServiceProducts based
    /// on the pre-populated set of XML files that serve local data. It simulates 
    /// responses from Marketplace Web Service Products service.
    /// </summary>
    /// <remarks>
    /// Use this to test your application without making a call to 
    /// Marketplace Web Service Products 
    /// 
    /// Note, current Mock Service implementation does not valiadate requests
    /// </remarks>
    public  class MarketplaceWebServiceProductsMock : MarketplaceWebServiceProducts {
    

        // Public API ------------------------------------------------------------//
    
        
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
        public GetMatchingProductResponse GetMatchingProduct(GetMatchingProductRequest request)
        {
            return Invoke<GetMatchingProductResponse>("GetMatchingProductResponse.xml");
        }
        
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
        public GetLowestOfferListingsForASINResponse GetLowestOfferListingsForASIN(GetLowestOfferListingsForASINRequest request)
        {
            return Invoke<GetLowestOfferListingsForASINResponse>("GetLowestOfferListingsForASINResponse.xml");
        }
        
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
        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return Invoke<GetServiceStatusResponse>("GetServiceStatusResponse.xml");
        }
        
        /// <summary>
        /// Get Matching Product For Id 
        /// </summary>
        /// <param name="request">Get Matching Product For Id  request</param>
        /// <returns>Get Matching Product For Id  Response from the service</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given Identifier list. Identifer type can be one of [SKU|ASIN|UPC|EAN|ISBN|GTIN|JAN]
        ///   
        /// </remarks>
        public GetMatchingProductForIdResponse GetMatchingProductForId(GetMatchingProductForIdRequest request)
        {
            return Invoke<GetMatchingProductForIdResponse>("GetMatchingProductForIdResponse.xml");
        }
        
        /// <summary>
        /// Get My Price For SKU 
        /// </summary>
        /// <param name="request">Get My Price For SKU  request</param>
        /// <returns>Get My Price For SKU  Response from the service</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given Identifier list. Identifer type can be one of [SKU|ASIN|UPC|EAN|ISBN|GTIN|JAN]
        ///   
        /// </remarks>
        public GetMyPriceForSKUResponse GetMyPriceForSKU(GetMyPriceForSKURequest request)
        {
            return Invoke<GetMyPriceForSKUResponse>("GetMyPriceForSKUResponse.xml");
        }
        
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
        public ListMatchingProductsResponse ListMatchingProducts(ListMatchingProductsRequest request)
        {
            return Invoke<ListMatchingProductsResponse>("ListMatchingProductsResponse.xml");
        }
        
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
        public GetCompetitivePricingForSKUResponse GetCompetitivePricingForSKU(GetCompetitivePricingForSKURequest request)
        {
            return Invoke<GetCompetitivePricingForSKUResponse>("GetCompetitivePricingForSKUResponse.xml");
        }
        
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
        public GetCompetitivePricingForASINResponse GetCompetitivePricingForASIN(GetCompetitivePricingForASINRequest request)
        {
            return Invoke<GetCompetitivePricingForASINResponse>("GetCompetitivePricingForASINResponse.xml");
        }
        
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
        public GetProductCategoriesForSKUResponse GetProductCategoriesForSKU(GetProductCategoriesForSKURequest request)
        {
            return Invoke<GetProductCategoriesForSKUResponse>("GetProductCategoriesForSKUResponse.xml");
        }
        
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
        public GetMyPriceForASINResponse GetMyPriceForASIN(GetMyPriceForASINRequest request)
        {
            return Invoke<GetMyPriceForASINResponse>("GetMyPriceForASINResponse.xml");
        }
        
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
        public GetLowestOfferListingsForSKUResponse GetLowestOfferListingsForSKU(GetLowestOfferListingsForSKURequest request)
        {
            return Invoke<GetLowestOfferListingsForSKUResponse>("GetLowestOfferListingsForSKUResponse.xml");
        }
        
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
        public GetProductCategoriesForASINResponse GetProductCategoriesForASIN(GetProductCategoriesForASINRequest request)
        {
            return Invoke<GetProductCategoriesForASINResponse>("GetProductCategoriesForASINResponse.xml");
        }

        // Private API ------------------------------------------------------------//

        private T Invoke<T>(String xmlResource)
        {
            XmlSerializer serlizer = new XmlSerializer(typeof(T));
            Stream xmlStream = Assembly.GetAssembly(this.GetType()).GetManifestResourceStream(xmlResource);
            return (T)serlizer.Deserialize(xmlStream);
        }
    }
}