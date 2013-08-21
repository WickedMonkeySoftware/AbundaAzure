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
    public class GetLowestOfferListingsForSKUResponse
    {
    
        private  List<GetLowestOfferListingsForSKUResult> getLowestOfferListingsForSKUResultField;

        private  ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the GetLowestOfferListingsForSKUResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetLowestOfferListingsForSKUResult")]
        public List<GetLowestOfferListingsForSKUResult> GetLowestOfferListingsForSKUResult
        {
            get
            {
                if (this.getLowestOfferListingsForSKUResultField == null)
                {
                    this.getLowestOfferListingsForSKUResultField = new List<GetLowestOfferListingsForSKUResult>();
                }
                return this.getLowestOfferListingsForSKUResultField;
            }
            set { this.getLowestOfferListingsForSKUResultField =  value; }
        }



        /// <summary>
        /// Sets the GetLowestOfferListingsForSKUResult property
        /// </summary>
        /// <param name="list">GetLowestOfferListingsForSKUResult property</param>
        /// <returns>this instance</returns>
        public GetLowestOfferListingsForSKUResponse WithGetLowestOfferListingsForSKUResult(params GetLowestOfferListingsForSKUResult[] list)
        {
            foreach (GetLowestOfferListingsForSKUResult item in list)
            {
                GetLowestOfferListingsForSKUResult.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if GetLowestOfferListingsForSKUResult property is set
        /// </summary>
        /// <returns>true if GetLowestOfferListingsForSKUResult property is set</returns>
        public Boolean IsSetGetLowestOfferListingsForSKUResult()
        {
            return (GetLowestOfferListingsForSKUResult.Count > 0);
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
        public GetLowestOfferListingsForSKUResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
            xml.Append("<GetLowestOfferListingsForSKUResponse xmlns=\"http://mws.amazonservices.com/schema/Products/2011-10-01\">");
            List<GetLowestOfferListingsForSKUResult> getLowestOfferListingsForSKUResultList = this.GetLowestOfferListingsForSKUResult;
            foreach (GetLowestOfferListingsForSKUResult getLowestOfferListingsForSKUResult in getLowestOfferListingsForSKUResultList) {
                xml.Append("<GetLowestOfferListingsForSKUResult SellerSKU=" + "\"" +  EscapeXML(getLowestOfferListingsForSKUResult.SellerSKU)  + "\"" +  " status=" + "\"" +  EscapeXML(getLowestOfferListingsForSKUResult.status)  + "\"" +  ">");
                xml.Append(getLowestOfferListingsForSKUResult.ToXMLFragment());
                xml.Append("</GetLowestOfferListingsForSKUResult>");
            }
            if (IsSetResponseMetadata()) {
                ResponseMetadata  responseMetadata = this.ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            } 
            xml.Append("</GetLowestOfferListingsForSKUResponse>");
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