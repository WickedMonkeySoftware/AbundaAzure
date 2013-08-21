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
using System.Text;


namespace MarketplaceWebServiceProducts.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class ListMatchingProductsRequest
    {
    
        private String sellerIdField;

        private String marketplaceIdField;

        private String queryField;

        private String queryContextIdField;


        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerId")]
        public String SellerId
        {
            get { return this.sellerIdField ; }
            set { this.sellerIdField= value; }
        }



        /// <summary>
        /// Sets the SellerId property
        /// </summary>
        /// <param name="sellerId">SellerId property</param>
        /// <returns>this instance</returns>
        public ListMatchingProductsRequest WithSellerId(String sellerId)
        {
            this.sellerIdField = sellerId;
            return this;
        }



        /// <summary>
        /// Checks if SellerId property is set
        /// </summary>
        /// <returns>true if SellerId property is set</returns>
        public Boolean IsSetSellerId()
        {
            return  this.sellerIdField != null;

        }


        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceId")]
        public String MarketplaceId
        {
            get { return this.marketplaceIdField ; }
            set { this.marketplaceIdField= value; }
        }



        /// <summary>
        /// Sets the MarketplaceId property
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property</param>
        /// <returns>this instance</returns>
        public ListMatchingProductsRequest WithMarketplaceId(String marketplaceId)
        {
            this.marketplaceIdField = marketplaceId;
            return this;
        }



        /// <summary>
        /// Checks if MarketplaceId property is set
        /// </summary>
        /// <returns>true if MarketplaceId property is set</returns>
        public Boolean IsSetMarketplaceId()
        {
            return  this.marketplaceIdField != null;

        }


        /// <summary>
        /// Gets and sets the Query property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Query")]
        public String Query
        {
            get { return this.queryField ; }
            set { this.queryField= value; }
        }



        /// <summary>
        /// Sets the Query property
        /// </summary>
        /// <param name="query">Query property</param>
        /// <returns>this instance</returns>
        public ListMatchingProductsRequest WithQuery(String query)
        {
            this.queryField = query;
            return this;
        }



        /// <summary>
        /// Checks if Query property is set
        /// </summary>
        /// <returns>true if Query property is set</returns>
        public Boolean IsSetQuery()
        {
            return  this.queryField != null;

        }


        /// <summary>
        /// Gets and sets the QueryContextId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueryContextId")]
        public String QueryContextId
        {
            get { return this.queryContextIdField ; }
            set { this.queryContextIdField= value; }
        }



        /// <summary>
        /// Sets the QueryContextId property
        /// </summary>
        /// <param name="queryContextId">QueryContextId property</param>
        /// <returns>this instance</returns>
        public ListMatchingProductsRequest WithQueryContextId(String queryContextId)
        {
            this.queryContextIdField = queryContextId;
            return this;
        }



        /// <summary>
        /// Checks if QueryContextId property is set
        /// </summary>
        /// <returns>true if QueryContextId property is set</returns>
        public Boolean IsSetQueryContextId()
        {
            return  this.queryContextIdField != null;

        }





    }

}