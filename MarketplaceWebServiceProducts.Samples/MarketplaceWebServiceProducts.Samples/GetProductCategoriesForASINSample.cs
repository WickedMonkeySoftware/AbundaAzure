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
    /// Get Product Categories For ASIN  Samples
    /// </summary>
    public class GetProductCategoriesForASINSample
    {
    
                                                                     
        /// <summary>
        /// Gets categories information for a product identified by
        /// the MarketplaceId and ASIN.
        /// 
        /// </summary>
        /// <param name="service">Instance of MarketplaceWebServiceProducts service</param>
        /// <param name="request">GetProductCategoriesForASINRequest request</param>
        public static void InvokeGetProductCategoriesForASIN(MarketplaceWebServiceProducts service, GetProductCategoriesForASINRequest request)
        {
            try 
            {
                GetProductCategoriesForASINResponse response = service.GetProductCategoriesForASIN(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetProductCategoriesForASINResponse");
                if (response.IsSetGetProductCategoriesForASINResult())
                {
                    Console.WriteLine("            GetProductCategoriesForASINResult");
                    GetProductCategoriesForASINResult  getProductCategoriesForASINResult = response.GetProductCategoriesForASINResult;
                    List<Categories> selfList = getProductCategoriesForASINResult.Self;
                    foreach (Categories self in selfList)
                    {
                        Console.WriteLine("                Self");
                        if (self.IsSetProductCategoryId())
                        {
                            Console.WriteLine("                    ProductCategoryId");
                            Console.WriteLine("                        {0}", self.ProductCategoryId);
                        }
                        if (self.IsSetProductCategoryName())
                        {
                            Console.WriteLine("                    ProductCategoryName");
                            Console.WriteLine("                        {0}", self.ProductCategoryName);
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
