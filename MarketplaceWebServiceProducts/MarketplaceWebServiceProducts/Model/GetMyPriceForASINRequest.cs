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
    public class GetMyPriceForASINRequest
    {
    
        private String sellerIdField;

        private String marketplaceIdField;

        private  ASINListType ASINListField;

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
        public GetMyPriceForASINRequest WithSellerId(String sellerId)
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
        public GetMyPriceForASINRequest WithMarketplaceId(String marketplaceId)
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
        /// Gets and sets the ASINList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASINList")]
        public ASINListType ASINList
        {
            get { return this.ASINListField ; }
            set { this.ASINListField = value; }
        }



        /// <summary>
        /// Sets the ASINList property
        /// </summary>
        /// <param name="ASINList">ASINList property</param>
        /// <returns>this instance</returns>
        public GetMyPriceForASINRequest WithASINList(ASINListType ASINList)
        {
            this.ASINListField = ASINList;
            return this;
        }



        /// <summary>
        /// Checks if ASINList property is set
        /// </summary>
        /// <returns>true if ASINList property is set</returns>
        public Boolean IsSetASINList()
        {
            return this.ASINListField != null;
        }







    }

}