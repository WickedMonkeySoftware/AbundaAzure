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
using MarketplaceWebServiceProducts.Mock;
using MarketplaceWebServiceProducts.Model;

namespace MarketplaceWebServiceProducts.Samples
{

    /// <summary>
    /// Marketplace Web Service Products  Samples
    /// </summary>
    public class MarketplaceWebServiceProductsSamples 
    {
    
       /**
        * Samples for Marketplace Web Service Products functionality
        */
        public static void Main(string [] args) 
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to Marketplace Web Service Products Samples!");
            Console.WriteLine("===========================================");

            Console.WriteLine("To get started:");
            Console.WriteLine("===========================================");
            Console.WriteLine("  - Fill in your MWS credentials");
            Console.WriteLine("  - Uncomment sample you're interested in trying");
            Console.WriteLine("  - Set request with desired parameters");
            Console.WriteLine("  - Hit F5 to run!");
            Console.WriteLine();

            Console.WriteLine("===========================================");
            Console.WriteLine("Samples Output");
            Console.WriteLine("===========================================");
            Console.WriteLine();

           /************************************************************************
            * Access Key ID and Secret Access Key ID
            ***********************************************************************/
            String accessKeyId = "<Your Access Key Id>";
            String secretAccessKey = "<Your Secret Access Key>";
            String merchantId = "<Your Merchant Id>";
            String marketplaceId = "<Your Marketplace Id>";

            /************************************************************************
             * The application name and version are included in each MWS call's
             * HTTP User-Agent field.
             ***********************************************************************/
            const string applicationName = "<Your Application Name>";
            const string applicationVersion = "<Your Application Version>";

            /************************************************************************
            * Uncomment to try advanced configuration options. Available options are:
            *
            *  - Signature Version
            *  - Proxy Host and Proxy Port
            *  - Service URL
            *  - User Agent String to be sent to Marketplace Web Service Products  service
            *
            ***********************************************************************/
            MarketplaceWebServiceProductsConfig config = new MarketplaceWebServiceProductsConfig();
            //
            // IMPORTANT: Uncomment out the appropriate line for the country you wish 
            // to sell in:
            // 
            // United States:
            // config.ServiceURL = "https://mws.amazonservices.com/Products/2011-10-01";
            //
            // Canada:
            // config.ServiceURL = "https://mws.amazonservices.ca/Products/2011-10-01";
            //
            // Europe:
            // config.ServiceURL = "https://mws-eu.amazonservices.com/Products/2011-10-01";
            //
            // Japan:
            // config.ServiceURL = "https://mws.amazonservices.jp/Products/2011-10-01";
            //
            // China:
            // config.ServiceURL = "https://mws.amazonservices.com.cn/Products/2011-10-01";
            //

            /************************************************************************
            * Instantiate  Implementation of Marketplace Web Service Products  
            ***********************************************************************/
            MarketplaceWebServiceProductsClient service = new MarketplaceWebServiceProductsClient(
                applicationName, applicationVersion, accessKeyId, secretAccessKey, config);
         
            /************************************************************************
            * Uncomment to try out Mock Service that simulates Marketplace Web Service Products 
            * responses without calling Marketplace Web Service Products  service.
            *
            * Responses are loaded from local XML files. You can tweak XML files to
            * experiment with various outputs during development
            *
            * XML files available under MarketplaceWebServiceProducts\Mock tree
            *
            ***********************************************************************/
            // MarketplaceWebServiceProducts service = new MarketplaceWebServiceProductsMock();


            /************************************************************************
            * Uncomment to invoke Get Matching Product Action
            ***********************************************************************/
            // GetMatchingProductRequest request = new GetMatchingProductRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetMatchingProductSample.InvokeGetMatchingProduct(service, request);
            /************************************************************************
            * Uncomment to invoke Get Lowest Offer Listings For ASIN Action
            ***********************************************************************/
            // GetLowestOfferListingsForASINRequest request = new GetLowestOfferListingsForASINRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetLowestOfferListingsForASINSample.InvokeGetLowestOfferListingsForASIN(service, request);
            /************************************************************************
            * Uncomment to invoke Get Service Status Action
            ***********************************************************************/
            // GetServiceStatusRequest request = new GetServiceStatusRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetServiceStatusSample.InvokeGetServiceStatus(service, request);
            /************************************************************************
            * Uncomment to invoke Get Matching Product For Id Action
            ***********************************************************************/
            // GetMatchingProductForIdRequest request = new GetMatchingProductForIdRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetMatchingProductForIdSample.InvokeGetMatchingProductForId(service, request);
            /************************************************************************
            * Uncomment to invoke Get My Price For SKU Action
            ***********************************************************************/
            // GetMyPriceForSKURequest request = new GetMyPriceForSKURequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetMyPriceForSKUSample.InvokeGetMyPriceForSKU(service, request);
            /************************************************************************
            * Uncomment to invoke List Matching Products Action
            ***********************************************************************/
            // ListMatchingProductsRequest request = new ListMatchingProductsRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // ListMatchingProductsSample.InvokeListMatchingProducts(service, request);
            /************************************************************************
            * Uncomment to invoke Get Competitive Pricing For SKU Action
            ***********************************************************************/
            // GetCompetitivePricingForSKURequest request = new GetCompetitivePricingForSKURequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetCompetitivePricingForSKUSample.InvokeGetCompetitivePricingForSKU(service, request);
            /************************************************************************
            * Uncomment to invoke Get Competitive Pricing For ASIN Action
            ***********************************************************************/
            // GetCompetitivePricingForASINRequest request = new GetCompetitivePricingForASINRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetCompetitivePricingForASINSample.InvokeGetCompetitivePricingForASIN(service, request);
            /************************************************************************
            * Uncomment to invoke Get Product Categories For SKU Action
            ***********************************************************************/
            // GetProductCategoriesForSKURequest request = new GetProductCategoriesForSKURequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetProductCategoriesForSKUSample.InvokeGetProductCategoriesForSKU(service, request);
            /************************************************************************
            * Uncomment to invoke Get My Price For ASIN Action
            ***********************************************************************/
            // GetMyPriceForASINRequest request = new GetMyPriceForASINRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetMyPriceForASINSample.InvokeGetMyPriceForASIN(service, request);
            /************************************************************************
            * Uncomment to invoke Get Lowest Offer Listings For SKU Action
            ***********************************************************************/
            // GetLowestOfferListingsForSKURequest request = new GetLowestOfferListingsForSKURequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetLowestOfferListingsForSKUSample.InvokeGetLowestOfferListingsForSKU(service, request);
            /************************************************************************
            * Uncomment to invoke Get Product Categories For ASIN Action
            ***********************************************************************/
            // GetProductCategoriesForASINRequest request = new GetProductCategoriesForASINRequest();
            // @TODO: set request parameters here
            // request.SellerId = merchantId;
            
            // GetProductCategoriesForASINSample.InvokeGetProductCategoriesForASIN(service, request);
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("End of output. You can close this window");
            Console.WriteLine("===========================================");

            System.Threading.Thread.Sleep(50000);
        }

    }
}
