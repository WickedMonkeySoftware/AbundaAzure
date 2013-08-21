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
    public class GetLowestOfferListingsForSKURequest
    {
    
        private String sellerIdField;

        private String marketplaceIdField;

        private  SellerSKUListType sellerSKUListField;
        private String itemConditionField;

        private Boolean? excludeMeField;


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
        public GetLowestOfferListingsForSKURequest WithSellerId(String sellerId)
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
        public GetLowestOfferListingsForSKURequest WithMarketplaceId(String marketplaceId)
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
        /// Gets and sets the SellerSKUList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerSKUList")]
        public SellerSKUListType SellerSKUList
        {
            get { return this.sellerSKUListField ; }
            set { this.sellerSKUListField = value; }
        }



        /// <summary>
        /// Sets the SellerSKUList property
        /// </summary>
        /// <param name="sellerSKUList">SellerSKUList property</param>
        /// <returns>this instance</returns>
        public GetLowestOfferListingsForSKURequest WithSellerSKUList(SellerSKUListType sellerSKUList)
        {
            this.sellerSKUListField = sellerSKUList;
            return this;
        }



        /// <summary>
        /// Checks if SellerSKUList property is set
        /// </summary>
        /// <returns>true if SellerSKUList property is set</returns>
        public Boolean IsSetSellerSKUList()
        {
            return this.sellerSKUListField != null;
        }




        /// <summary>
        /// Gets and sets the ItemCondition property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemCondition")]
        public String ItemCondition
        {
            get { return this.itemConditionField ; }
            set { this.itemConditionField= value; }
        }



        /// <summary>
        /// Sets the ItemCondition property
        /// </summary>
        /// <param name="itemCondition">ItemCondition property</param>
        /// <returns>this instance</returns>
        public GetLowestOfferListingsForSKURequest WithItemCondition(String itemCondition)
        {
            this.itemConditionField = itemCondition;
            return this;
        }



        /// <summary>
        /// Checks if ItemCondition property is set
        /// </summary>
        /// <returns>true if ItemCondition property is set</returns>
        public Boolean IsSetItemCondition()
        {
            return  this.itemConditionField != null;

        }


        /// <summary>
        /// Gets and sets the ExcludeMe property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExcludeMe")]
        public Boolean ExcludeMe
        {
            get { return this.excludeMeField.GetValueOrDefault() ; }
            set { this.excludeMeField= value; }
        }



        /// <summary>
        /// Sets the ExcludeMe property
        /// </summary>
        /// <param name="excludeMe">ExcludeMe property</param>
        /// <returns>this instance</returns>
        public GetLowestOfferListingsForSKURequest WithExcludeMe(Boolean excludeMe)
        {
            this.excludeMeField = excludeMe;
            return this;
        }



        /// <summary>
        /// Checks if ExcludeMe property is set
        /// </summary>
        /// <returns>true if ExcludeMe property is set</returns>
        public Boolean IsSetExcludeMe()
        {
            return  this.excludeMeField.HasValue;

        }





    }

}