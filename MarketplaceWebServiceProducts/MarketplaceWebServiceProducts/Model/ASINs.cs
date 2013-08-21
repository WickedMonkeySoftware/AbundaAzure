/******************************************************************************* 
 *  Copyright 2008-2009 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  Generated: Wed Sep 28 00:18:35 GMT 2011 
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
    public class ASINs
    {
    
        private List<String> ASINField;


        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ASIN")]
        public List<String> ASIN
        {
            get
            {
                if (this.ASINField == null)
                {
                    this.ASINField = new List<String>();
                }
                return this.ASINField;
            }
            set { this.ASINField =  value; }
        }



        /// <summary>
        /// Sets the ASIN property
        /// </summary>
        /// <param name="list">ASIN property</param>
        /// <returns>this instance</returns>
        public ASINs WithASIN(params String[] list)
        {
            foreach (String item in list)
            {
                ASIN.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks of ASIN property is set
        /// </summary>
        /// <returns>true if ASIN property is set</returns>
        public Boolean IsSetASIN()
        {
            return (ASIN.Count > 0);
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
            List<String> ASINObjList  =  this.ASIN;
            foreach (String ASINObj in ASINObjList) { 
                xml.Append("<ASIN>");
                xml.Append(EscapeXML(ASINObj));
                xml.Append("</ASIN>");
            }	
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
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