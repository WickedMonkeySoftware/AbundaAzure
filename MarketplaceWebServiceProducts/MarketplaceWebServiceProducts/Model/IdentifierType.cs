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
    public class IdentifierType
    {
    
        private  ASINIdentifier marketplaceASINField;
        private  SellerSKUIdentifier SKUIdentifierField;

        /// <summary>
        /// Gets and sets the MarketplaceASIN property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceASIN")]
        public ASINIdentifier MarketplaceASIN
        {
            get { return this.marketplaceASINField ; }
            set { this.marketplaceASINField = value; }
        }



        /// <summary>
        /// Sets the MarketplaceASIN property
        /// </summary>
        /// <param name="marketplaceASIN">MarketplaceASIN property</param>
        /// <returns>this instance</returns>
        public IdentifierType WithMarketplaceASIN(ASINIdentifier marketplaceASIN)
        {
            this.marketplaceASINField = marketplaceASIN;
            return this;
        }



        /// <summary>
        /// Checks if MarketplaceASIN property is set
        /// </summary>
        /// <returns>true if MarketplaceASIN property is set</returns>
        public Boolean IsSetMarketplaceASIN()
        {
            return this.marketplaceASINField != null;
        }




        /// <summary>
        /// Gets and sets the SKUIdentifier property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SKUIdentifier")]
        public SellerSKUIdentifier SKUIdentifier
        {
            get { return this.SKUIdentifierField ; }
            set { this.SKUIdentifierField = value; }
        }



        /// <summary>
        /// Sets the SKUIdentifier property
        /// </summary>
        /// <param name="SKUIdentifier">SKUIdentifier property</param>
        /// <returns>this instance</returns>
        public IdentifierType WithSKUIdentifier(SellerSKUIdentifier SKUIdentifier)
        {
            this.SKUIdentifierField = SKUIdentifier;
            return this;
        }



        /// <summary>
        /// Checks if SKUIdentifier property is set
        /// </summary>
        /// <returns>true if SKUIdentifier property is set</returns>
        public Boolean IsSetSKUIdentifier()
        {
            return this.SKUIdentifierField != null;
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
            if (IsSetMarketplaceASIN()) {
                ASINIdentifier  marketplaceASINObj = this.MarketplaceASIN;
                xml.Append("<MarketplaceASIN>");
                xml.Append(marketplaceASINObj.ToXMLFragment());
                xml.Append("</MarketplaceASIN>");
            } 
            if (IsSetSKUIdentifier()) {
                SellerSKUIdentifier  SKUIdentifierObj = this.SKUIdentifier;
                xml.Append("<SKUIdentifier>");
                xml.Append(SKUIdentifierObj.ToXMLFragment());
                xml.Append("</SKUIdentifier>");
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