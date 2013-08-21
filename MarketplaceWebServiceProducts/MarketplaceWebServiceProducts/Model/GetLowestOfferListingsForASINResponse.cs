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
    public class GetLowestOfferListingsForASINResponse
    {
    
        private  List<GetLowestOfferListingsForASINResult> getLowestOfferListingsForASINResultField;

        private  ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the GetLowestOfferListingsForASINResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetLowestOfferListingsForASINResult")]
        public List<GetLowestOfferListingsForASINResult> GetLowestOfferListingsForASINResult
        {
            get
            {
                if (this.getLowestOfferListingsForASINResultField == null)
                {
                    this.getLowestOfferListingsForASINResultField = new List<GetLowestOfferListingsForASINResult>();
                }
                return this.getLowestOfferListingsForASINResultField;
            }
            set { this.getLowestOfferListingsForASINResultField =  value; }
        }



        /// <summary>
        /// Sets the GetLowestOfferListingsForASINResult property
        /// </summary>
        /// <param name="list">GetLowestOfferListingsForASINResult property</param>
        /// <returns>this instance</returns>
        public GetLowestOfferListingsForASINResponse WithGetLowestOfferListingsForASINResult(params GetLowestOfferListingsForASINResult[] list)
        {
            foreach (GetLowestOfferListingsForASINResult item in list)
            {
                GetLowestOfferListingsForASINResult.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if GetLowestOfferListingsForASINResult property is set
        /// </summary>
        /// <returns>true if GetLowestOfferListingsForASINResult property is set</returns>
        public Boolean IsSetGetLowestOfferListingsForASINResult()
        {
            return (GetLowestOfferListingsForASINResult.Count > 0);
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
        public GetLowestOfferListingsForASINResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
            xml.Append("<GetLowestOfferListingsForASINResponse xmlns=\"http://mws.amazonservices.com/schema/Products/2011-10-01\">");
            List<GetLowestOfferListingsForASINResult> getLowestOfferListingsForASINResultList = this.GetLowestOfferListingsForASINResult;
            foreach (GetLowestOfferListingsForASINResult getLowestOfferListingsForASINResult in getLowestOfferListingsForASINResultList) {
                xml.Append("<GetLowestOfferListingsForASINResult ASIN=" + "\"" +  EscapeXML(getLowestOfferListingsForASINResult.ASIN)  + "\"" +  " status=" + "\"" +  EscapeXML(getLowestOfferListingsForASINResult.status)  + "\"" +  ">");
                xml.Append(getLowestOfferListingsForASINResult.ToXMLFragment());
                xml.Append("</GetLowestOfferListingsForASINResult>");
            }
            if (IsSetResponseMetadata()) {
                ResponseMetadata  responseMetadata = this.ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            } 
            xml.Append("</GetLowestOfferListingsForASINResponse>");
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