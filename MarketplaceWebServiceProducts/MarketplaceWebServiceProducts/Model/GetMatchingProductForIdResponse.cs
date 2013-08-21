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
    public class GetMatchingProductForIdResponse
    {
    
        private  List<GetMatchingProductForIdResult> getMatchingProductForIdResultField;

        private  ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the GetMatchingProductForIdResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetMatchingProductForIdResult")]
        public List<GetMatchingProductForIdResult> GetMatchingProductForIdResult
        {
            get
            {
                if (this.getMatchingProductForIdResultField == null)
                {
                    this.getMatchingProductForIdResultField = new List<GetMatchingProductForIdResult>();
                }
                return this.getMatchingProductForIdResultField;
            }
            set { this.getMatchingProductForIdResultField =  value; }
        }



        /// <summary>
        /// Sets the GetMatchingProductForIdResult property
        /// </summary>
        /// <param name="list">GetMatchingProductForIdResult property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductForIdResponse WithGetMatchingProductForIdResult(params GetMatchingProductForIdResult[] list)
        {
            foreach (GetMatchingProductForIdResult item in list)
            {
                GetMatchingProductForIdResult.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if GetMatchingProductForIdResult property is set
        /// </summary>
        /// <returns>true if GetMatchingProductForIdResult property is set</returns>
        public Boolean IsSetGetMatchingProductForIdResult()
        {
            return (GetMatchingProductForIdResult.Count > 0);
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
        public GetMatchingProductForIdResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
            xml.Append("<GetMatchingProductForIdResponse xmlns=\"http://mws.amazonservices.com/schema/Products/2011-10-01\">");
            List<GetMatchingProductForIdResult> getMatchingProductForIdResultList = this.GetMatchingProductForIdResult;
            foreach (GetMatchingProductForIdResult getMatchingProductForIdResult in getMatchingProductForIdResultList) {
                xml.Append("<GetMatchingProductForIdResult Id=" + "\"" +  EscapeXML(getMatchingProductForIdResult.Id)  + "\"" +  " IdType=" + "\"" +  EscapeXML(getMatchingProductForIdResult.IdType)  + "\"" +  " status=" + "\"" +  EscapeXML(getMatchingProductForIdResult.status)  + "\"" +  ">");
                xml.Append(getMatchingProductForIdResult.ToXMLFragment());
                xml.Append("</GetMatchingProductForIdResult>");
            }
            if (IsSetResponseMetadata()) {
                ResponseMetadata  responseMetadata = this.ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            } 
            xml.Append("</GetMatchingProductForIdResponse>");
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