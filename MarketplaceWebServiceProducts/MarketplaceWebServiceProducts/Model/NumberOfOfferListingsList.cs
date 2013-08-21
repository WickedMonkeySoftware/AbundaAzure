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
    public class NumberOfOfferListingsList
    {
    
        private  List<OfferListingCountType> offerListingCountField;


        /// <summary>
        /// Gets and sets the OfferListingCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OfferListingCount")]
        public List<OfferListingCountType> OfferListingCount
        {
            get
            {
                if (this.offerListingCountField == null)
                {
                    this.offerListingCountField = new List<OfferListingCountType>();
                }
                return this.offerListingCountField;
            }
            set { this.offerListingCountField =  value; }
        }



        /// <summary>
        /// Sets the OfferListingCount property
        /// </summary>
        /// <param name="list">OfferListingCount property</param>
        /// <returns>this instance</returns>
        public NumberOfOfferListingsList WithOfferListingCount(params OfferListingCountType[] list)
        {
            foreach (OfferListingCountType item in list)
            {
                OfferListingCount.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if OfferListingCount property is set
        /// </summary>
        /// <returns>true if OfferListingCount property is set</returns>
        public Boolean IsSetOfferListingCount()
        {
            return (OfferListingCount.Count > 0);
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
            List<OfferListingCountType> offerListingCountObjList = this.OfferListingCount;
            foreach (OfferListingCountType offerListingCountObj in offerListingCountObjList) {
                xml.Append("<OfferListingCount condition=" + "\"" +  EscapeXML(offerListingCountObj.condition)  + "\"" +  ">");
                xml.Append(offerListingCountObj.Value);
                xml.Append("</OfferListingCount>");
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