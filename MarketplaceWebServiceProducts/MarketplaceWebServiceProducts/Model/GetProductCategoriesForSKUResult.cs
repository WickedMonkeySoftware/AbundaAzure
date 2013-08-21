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
    public class GetProductCategoriesForSKUResult
    {
    
        private  List<Categories> selfField;


        /// <summary>
        /// Gets and sets the Self property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Self")]
        public List<Categories> Self
        {
            get
            {
                if (this.selfField == null)
                {
                    this.selfField = new List<Categories>();
                }
                return this.selfField;
            }
            set { this.selfField =  value; }
        }



        /// <summary>
        /// Sets the Self property
        /// </summary>
        /// <param name="list">Self property</param>
        /// <returns>this instance</returns>
        public GetProductCategoriesForSKUResult WithSelf(params Categories[] list)
        {
            foreach (Categories item in list)
            {
                Self.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if Self property is set
        /// </summary>
        /// <returns>true if Self property is set</returns>
        public Boolean IsSetSelf()
        {
            return (Self.Count > 0);
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
            List<Categories> selfObjList = this.Self;
            foreach (Categories selfObj in selfObjList) {
                xml.Append("<Self>");
                xml.Append(selfObj.ToXMLFragment());
                xml.Append("</Self>");
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