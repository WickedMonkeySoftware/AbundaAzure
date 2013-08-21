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
    public class OfferType
    {
    
        private  PriceType buyingPriceField;
        private  MoneyType regularPriceField;
        private String fulfillmentChannelField;

        private String itemConditionField;

        private String itemSubConditionField;

        private String sellerIdField;

        private String sellerSKUField;


        /// <summary>
        /// Gets and sets the BuyingPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BuyingPrice")]
        public PriceType BuyingPrice
        {
            get { return this.buyingPriceField ; }
            set { this.buyingPriceField = value; }
        }



        /// <summary>
        /// Sets the BuyingPrice property
        /// </summary>
        /// <param name="buyingPrice">BuyingPrice property</param>
        /// <returns>this instance</returns>
        public OfferType WithBuyingPrice(PriceType buyingPrice)
        {
            this.buyingPriceField = buyingPrice;
            return this;
        }



        /// <summary>
        /// Checks if BuyingPrice property is set
        /// </summary>
        /// <returns>true if BuyingPrice property is set</returns>
        public Boolean IsSetBuyingPrice()
        {
            return this.buyingPriceField != null;
        }




        /// <summary>
        /// Gets and sets the RegularPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RegularPrice")]
        public MoneyType RegularPrice
        {
            get { return this.regularPriceField ; }
            set { this.regularPriceField = value; }
        }



        /// <summary>
        /// Sets the RegularPrice property
        /// </summary>
        /// <param name="regularPrice">RegularPrice property</param>
        /// <returns>this instance</returns>
        public OfferType WithRegularPrice(MoneyType regularPrice)
        {
            this.regularPriceField = regularPrice;
            return this;
        }



        /// <summary>
        /// Checks if RegularPrice property is set
        /// </summary>
        /// <returns>true if RegularPrice property is set</returns>
        public Boolean IsSetRegularPrice()
        {
            return this.regularPriceField != null;
        }




        /// <summary>
        /// Gets and sets the FulfillmentChannel property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FulfillmentChannel")]
        public String FulfillmentChannel
        {
            get { return this.fulfillmentChannelField ; }
            set { this.fulfillmentChannelField= value; }
        }



        /// <summary>
        /// Sets the FulfillmentChannel property
        /// </summary>
        /// <param name="fulfillmentChannel">FulfillmentChannel property</param>
        /// <returns>this instance</returns>
        public OfferType WithFulfillmentChannel(String fulfillmentChannel)
        {
            this.fulfillmentChannelField = fulfillmentChannel;
            return this;
        }



        /// <summary>
        /// Checks if FulfillmentChannel property is set
        /// </summary>
        /// <returns>true if FulfillmentChannel property is set</returns>
        public Boolean IsSetFulfillmentChannel()
        {
            return  this.fulfillmentChannelField != null;

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
        public OfferType WithItemCondition(String itemCondition)
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
        /// Gets and sets the ItemSubCondition property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemSubCondition")]
        public String ItemSubCondition
        {
            get { return this.itemSubConditionField ; }
            set { this.itemSubConditionField= value; }
        }



        /// <summary>
        /// Sets the ItemSubCondition property
        /// </summary>
        /// <param name="itemSubCondition">ItemSubCondition property</param>
        /// <returns>this instance</returns>
        public OfferType WithItemSubCondition(String itemSubCondition)
        {
            this.itemSubConditionField = itemSubCondition;
            return this;
        }



        /// <summary>
        /// Checks if ItemSubCondition property is set
        /// </summary>
        /// <returns>true if ItemSubCondition property is set</returns>
        public Boolean IsSetItemSubCondition()
        {
            return  this.itemSubConditionField != null;

        }


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
        public OfferType WithSellerId(String sellerId)
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
        /// Gets and sets the SellerSKU property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerSKU")]
        public String SellerSKU
        {
            get { return this.sellerSKUField ; }
            set { this.sellerSKUField= value; }
        }



        /// <summary>
        /// Sets the SellerSKU property
        /// </summary>
        /// <param name="sellerSKU">SellerSKU property</param>
        /// <returns>this instance</returns>
        public OfferType WithSellerSKU(String sellerSKU)
        {
            this.sellerSKUField = sellerSKU;
            return this;
        }



        /// <summary>
        /// Checks if SellerSKU property is set
        /// </summary>
        /// <returns>true if SellerSKU property is set</returns>
        public Boolean IsSetSellerSKU()
        {
            return  this.sellerSKUField != null;

        }




        /// <summary>
        /// XML fragment representation of this object
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only
        /// </remarks>


        protected internal String ToXMLFragment() {
            StringBuilder xml = new StringBuilder();
            if (IsSetBuyingPrice()) {
                PriceType  buyingPriceObj = this.BuyingPrice;
                xml.Append("<BuyingPrice>");
                xml.Append(buyingPriceObj.ToXMLFragment());
                xml.Append("</BuyingPrice>");
            } 
            if (IsSetRegularPrice()) {
                MoneyType  regularPriceObj = this.RegularPrice;
                xml.Append("<RegularPrice>");
                xml.Append(regularPriceObj.ToXMLFragment());
                xml.Append("</RegularPrice>");
            } 
            if (IsSetFulfillmentChannel()) {
                xml.Append("<FulfillmentChannel>");
                xml.Append(EscapeXML(this.FulfillmentChannel));
                xml.Append("</FulfillmentChannel>");
            }
            if (IsSetItemCondition()) {
                xml.Append("<ItemCondition>");
                xml.Append(EscapeXML(this.ItemCondition));
                xml.Append("</ItemCondition>");
            }
            if (IsSetItemSubCondition()) {
                xml.Append("<ItemSubCondition>");
                xml.Append(EscapeXML(this.ItemSubCondition));
                xml.Append("</ItemSubCondition>");
            }
            if (IsSetSellerId()) {
                xml.Append("<SellerId>");
                xml.Append(EscapeXML(this.SellerId));
                xml.Append("</SellerId>");
            }
            if (IsSetSellerSKU()) {
                xml.Append("<SellerSKU>");
                xml.Append(EscapeXML(this.SellerSKU));
                xml.Append("</SellerSKU>");
            }
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
            if (str == null)
                return "null";
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c) {
                case '&':
                    sb.Append("&amp;");
                    break;
                case '<':
                    sb.Append("&lt;");
                    break;
                case '>':
                    sb.Append("&gt;");
                    break;
                case '\'':
                    sb.Append("&#039;");
                    break;
                case '"':
                    sb.Append("&quot;");
                    break;
                default:
                    sb.Append(c);
                    break;
                }
            }
            return sb.ToString();
        }



    }

}