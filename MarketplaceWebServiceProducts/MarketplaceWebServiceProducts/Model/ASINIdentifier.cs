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
    public class ASINIdentifier
    {
    
        private String marketplaceIdField;

        private String ASINField;


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
        public ASINIdentifier WithMarketplaceId(String marketplaceId)
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
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASIN")]
        public String ASIN
        {
            get { return this.ASINField ; }
            set { this.ASINField= value; }
        }



        /// <summary>
        /// Sets the ASIN property
        /// </summary>
        /// <param name="ASIN">ASIN property</param>
        /// <returns>this instance</returns>
        public ASINIdentifier WithASIN(String ASIN)
        {
            this.ASINField = ASIN;
            return this;
        }



        /// <summary>
        /// Checks if ASIN property is set
        /// </summary>
        /// <returns>true if ASIN property is set</returns>
        public Boolean IsSetASIN()
        {
            return  this.ASINField != null;

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
            if (IsSetMarketplaceId()) {
                xml.Append("<MarketplaceId>");
                xml.Append(EscapeXML(this.MarketplaceId));
                xml.Append("</MarketplaceId>");
            }
            if (IsSetASIN()) {
                xml.Append("<ASIN>");
                xml.Append(EscapeXML(this.ASIN));
                xml.Append("</ASIN>");
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