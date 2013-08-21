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
    public class QualifiersType
    {
    
        private String itemConditionField;

        private String itemSubconditionField;

        private String fulfillmentChannelField;

        private String shipsDomesticallyField;

        private  ShippingTimeType shippingTimeField;
        private String sellerPositiveFeedbackRatingField;


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
        public QualifiersType WithItemCondition(String itemCondition)
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
        /// Gets and sets the ItemSubcondition property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemSubcondition")]
        public String ItemSubcondition
        {
            get { return this.itemSubconditionField ; }
            set { this.itemSubconditionField= value; }
        }



        /// <summary>
        /// Sets the ItemSubcondition property
        /// </summary>
        /// <param name="itemSubcondition">ItemSubcondition property</param>
        /// <returns>this instance</returns>
        public QualifiersType WithItemSubcondition(String itemSubcondition)
        {
            this.itemSubconditionField = itemSubcondition;
            return this;
        }



        /// <summary>
        /// Checks if ItemSubcondition property is set
        /// </summary>
        /// <returns>true if ItemSubcondition property is set</returns>
        public Boolean IsSetItemSubcondition()
        {
            return  this.itemSubconditionField != null;

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
        public QualifiersType WithFulfillmentChannel(String fulfillmentChannel)
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
        /// Gets and sets the ShipsDomestically property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShipsDomestically")]
        public String ShipsDomestically
        {
            get { return this.shipsDomesticallyField ; }
            set { this.shipsDomesticallyField= value; }
        }



        /// <summary>
        /// Sets the ShipsDomestically property
        /// </summary>
        /// <param name="shipsDomestically">ShipsDomestically property</param>
        /// <returns>this instance</returns>
        public QualifiersType WithShipsDomestically(String shipsDomestically)
        {
            this.shipsDomesticallyField = shipsDomestically;
            return this;
        }



        /// <summary>
        /// Checks if ShipsDomestically property is set
        /// </summary>
        /// <returns>true if ShipsDomestically property is set</returns>
        public Boolean IsSetShipsDomestically()
        {
            return  this.shipsDomesticallyField != null;

        }


        /// <summary>
        /// Gets and sets the ShippingTime property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShippingTime")]
        public ShippingTimeType ShippingTime
        {
            get { return this.shippingTimeField ; }
            set { this.shippingTimeField = value; }
        }



        /// <summary>
        /// Sets the ShippingTime property
        /// </summary>
        /// <param name="shippingTime">ShippingTime property</param>
        /// <returns>this instance</returns>
        public QualifiersType WithShippingTime(ShippingTimeType shippingTime)
        {
            this.shippingTimeField = shippingTime;
            return this;
        }



        /// <summary>
        /// Checks if ShippingTime property is set
        /// </summary>
        /// <returns>true if ShippingTime property is set</returns>
        public Boolean IsSetShippingTime()
        {
            return this.shippingTimeField != null;
        }




        /// <summary>
        /// Gets and sets the SellerPositiveFeedbackRating property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerPositiveFeedbackRating")]
        public String SellerPositiveFeedbackRating
        {
            get { return this.sellerPositiveFeedbackRatingField ; }
            set { this.sellerPositiveFeedbackRatingField= value; }
        }



        /// <summary>
        /// Sets the SellerPositiveFeedbackRating property
        /// </summary>
        /// <param name="sellerPositiveFeedbackRating">SellerPositiveFeedbackRating property</param>
        /// <returns>this instance</returns>
        public QualifiersType WithSellerPositiveFeedbackRating(String sellerPositiveFeedbackRating)
        {
            this.sellerPositiveFeedbackRatingField = sellerPositiveFeedbackRating;
            return this;
        }



        /// <summary>
        /// Checks if SellerPositiveFeedbackRating property is set
        /// </summary>
        /// <returns>true if SellerPositiveFeedbackRating property is set</returns>
        public Boolean IsSetSellerPositiveFeedbackRating()
        {
            return  this.sellerPositiveFeedbackRatingField != null;

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
            if (IsSetItemCondition()) {
                xml.Append("<ItemCondition>");
                xml.Append(EscapeXML(this.ItemCondition));
                xml.Append("</ItemCondition>");
            }
            if (IsSetItemSubcondition()) {
                xml.Append("<ItemSubcondition>");
                xml.Append(EscapeXML(this.ItemSubcondition));
                xml.Append("</ItemSubcondition>");
            }
            if (IsSetFulfillmentChannel()) {
                xml.Append("<FulfillmentChannel>");
                xml.Append(EscapeXML(this.FulfillmentChannel));
                xml.Append("</FulfillmentChannel>");
            }
            if (IsSetShipsDomestically()) {
                xml.Append("<ShipsDomestically>");
                xml.Append(EscapeXML(this.ShipsDomestically));
                xml.Append("</ShipsDomestically>");
            }
            if (IsSetShippingTime()) {
                ShippingTimeType  shippingTimeObj = this.ShippingTime;
                xml.Append("<ShippingTime>");
                xml.Append(shippingTimeObj.ToXMLFragment());
                xml.Append("</ShippingTime>");
            } 
            if (IsSetSellerPositiveFeedbackRating()) {
                xml.Append("<SellerPositiveFeedbackRating>");
                xml.Append(EscapeXML(this.SellerPositiveFeedbackRating));
                xml.Append("</SellerPositiveFeedbackRating>");
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