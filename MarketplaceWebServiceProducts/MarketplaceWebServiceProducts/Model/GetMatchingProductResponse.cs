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
    public class GetMatchingProductResponse
    {
    
        private  List<GetMatchingProductResult> getMatchingProductResultField;

        private  ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the GetMatchingProductResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetMatchingProductResult")]
        public List<GetMatchingProductResult> GetMatchingProductResult
        {
            get
            {
                if (this.getMatchingProductResultField == null)
                {
                    this.getMatchingProductResultField = new List<GetMatchingProductResult>();
                }
                return this.getMatchingProductResultField;
            }
            set { this.getMatchingProductResultField =  value; }
        }



        /// <summary>
        /// Sets the GetMatchingProductResult property
        /// </summary>
        /// <param name="list">GetMatchingProductResult property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductResponse WithGetMatchingProductResult(params GetMatchingProductResult[] list)
        {
            foreach (GetMatchingProductResult item in list)
            {
                GetMatchingProductResult.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if GetMatchingProductResult property is set
        /// </summary>
        /// <returns>true if GetMatchingProductResult property is set</returns>
        public Boolean IsSetGetMatchingProductResult()
        {
            return (GetMatchingProductResult.Count > 0);
        }


        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField ; }
            set { this.responseMetadataField = value; }
        }



        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
        }



        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public Boolean IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }






        /// <summary>
        /// XML Representation for this object
        /// </summary>
        /// <returns>XML String</returns>

        public String ToXML() {
            StringBuilder xml = new StringBuilder();
            xml.Append("<GetMatchingProductResponse xmlns=\"http://mws.amazonservices.com/schema/Products/2011-10-01\">");
            List<GetMatchingProductResult> getMatchingProductResultList = this.GetMatchingProductResult;
            foreach (GetMatchingProductResult getMatchingProductResult in getMatchingProductResultList) {
                xml.Append("<GetMatchingProductResult ASIN=" + "\"" +  EscapeXML(getMatchingProductResult.ASIN)  + "\"" +  " status=" + "\"" +  EscapeXML(getMatchingProductResult.status)  + "\"" +  ">");
                xml.Append(getMatchingProductResult.ToXMLFragment());
                xml.Append("</GetMatchingProductResult>");
            }
            if (IsSetResponseMetadata()) {
                ResponseMetadata  responseMetadata = this.ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            } 
            xml.Append("</GetMatchingProductResponse>");
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

        private ResponseHeaderMetadata responseHeaderMetadata;
                public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return responseHeaderMetadata; }
            set { this.responseHeaderMetadata = value; }
        }



    }

}