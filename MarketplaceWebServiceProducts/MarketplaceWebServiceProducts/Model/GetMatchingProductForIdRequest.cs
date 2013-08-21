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
    public class GetMatchingProductForIdRequest
    {
    
        private String sellerIdField;

        private String marketplaceIdField;

        private String idTypeField;

        private  IdListType idListField;

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
        public GetMatchingProductForIdRequest WithSellerId(String sellerId)
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
        public GetMatchingProductForIdRequest WithMarketplaceId(String marketplaceId)
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
        /// Gets and sets the IdType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IdType")]
        public String IdType
        {
            get { return this.idTypeField ; }
            set { this.idTypeField= value; }
        }



        /// <summary>
        /// Sets the IdType property
        /// </summary>
        /// <param name="idType">IdType property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductForIdRequest WithIdType(String idType)
        {
            this.idTypeField = idType;
            return this;
        }



        /// <summary>
        /// Checks if IdType property is set
        /// </summary>
        /// <returns>true if IdType property is set</returns>
        public Boolean IsSetIdType()
        {
            return  this.idTypeField != null;

        }


        /// <summary>
        /// Gets and sets the IdList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IdList")]
        public IdListType IdList
        {
            get { return this.idListField ; }
            set { this.idListField = value; }
        }



        /// <summary>
        /// Sets the IdList property
        /// </summary>
        /// <param name="idList">IdList property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductForIdRequest WithIdList(IdListType idList)
        {
            this.idListField = idList;
            return this;
        }



        /// <summary>
        /// Checks if IdList property is set
        /// </summary>
        /// <returns>true if IdList property is set</returns>
        public Boolean IsSetIdList()
        {
            return this.idListField != null;
        }







    }

}