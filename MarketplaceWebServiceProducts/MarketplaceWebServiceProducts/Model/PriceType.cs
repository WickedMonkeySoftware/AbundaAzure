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
    public class PriceType
    {
    
        private  MoneyType landedPriceField;
        private  MoneyType listingPriceField;
        private  MoneyType shippingField;

        /// <summary>
        /// Gets and sets the LandedPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LandedPrice")]
        public MoneyType LandedPrice
        {
            get { return this.landedPriceField ; }
            set { this.landedPriceField = value; }
        }



        /// <summary>
        /// Sets the LandedPrice property
        /// </summary>
        /// <param name="landedPrice">LandedPrice property</param>
        /// <returns>this instance</returns>
        public PriceType WithLandedPrice(MoneyType landedPrice)
        {
            this.landedPriceField = landedPrice;
            return this;
        }



        /// <summary>
        /// Checks if LandedPrice property is set
        /// </summary>
        /// <returns>true if LandedPrice property is set</returns>
        public Boolean IsSetLandedPrice()
        {
            return this.landedPriceField != null;
        }




        /// <summary>
        /// Gets and sets the ListingPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListingPrice")]
        public MoneyType ListingPrice
        {
            get { return this.listingPriceField ; }
            set { this.listingPriceField = value; }
        }



        /// <summary>
        /// Sets the ListingPrice property
        /// </summary>
        /// <param name="listingPrice">ListingPrice property</param>
        /// <returns>this instance</returns>
        public PriceType WithListingPrice(MoneyType listingPrice)
        {
            this.listingPriceField = listingPrice;
            return this;
        }



        /// <summary>
        /// Checks if ListingPrice property is set
        /// </summary>
        /// <returns>true if ListingPrice property is set</returns>
        public Boolean IsSetListingPrice()
        {
            return this.listingPriceField != null;
        }




        /// <summary>
        /// Gets and sets the Shipping property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Shipping")]
        public MoneyType Shipping
        {
            get { return this.shippingField ; }
            set { this.shippingField = value; }
        }



        /// <summary>
        /// Sets the Shipping property
        /// </summary>
        /// <param name="shipping">Shipping property</param>
        /// <returns>this instance</returns>
        public PriceType WithShipping(MoneyType shipping)
        {
            this.shippingField = shipping;
            return this;
        }



        /// <summary>
        /// Checks if Shipping property is set
        /// </summary>
        /// <returns>true if Shipping property is set</returns>
        public Boolean IsSetShipping()
        {
            return this.shippingField != null;
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
            if (IsSetLandedPrice()) {
                MoneyType  landedPriceObj = this.LandedPrice;
                xml.Append("<LandedPrice>");
                xml.Append(landedPriceObj.ToXMLFragment());
                xml.Append("</LandedPrice>");
            } 
            if (IsSetListingPrice()) {
                MoneyType  listingPriceObj = this.ListingPrice;
                xml.Append("<ListingPrice>");
                xml.Append(listingPriceObj.ToXMLFragment());
                xml.Append("</ListingPrice>");
            } 
            if (IsSetShipping()) {
                MoneyType  shippingObj = this.Shipping;
                xml.Append("<Shipping>");
                xml.Append(shippingObj.ToXMLFragment());
                xml.Append("</Shipping>");
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