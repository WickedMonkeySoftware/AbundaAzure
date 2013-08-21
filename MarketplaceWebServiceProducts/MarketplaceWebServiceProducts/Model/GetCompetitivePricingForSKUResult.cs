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
    public class GetCompetitivePricingForSKUResult
    {
    
        private  String sellerSKUField;
        private  String statusField;
        private  Product productField;
        private  Error errorField;

        /// <summary>
        /// Gets and sets the Product property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Product")]
        public Product Product
        {
            get { return this.productField ; }
            set { this.productField = value; }
        }



        /// <summary>
        /// Sets the Product property
        /// </summary>
        /// <param name="product">Product property</param>
        /// <returns>this instance</returns>
        public GetCompetitivePricingForSKUResult WithProduct(Product product)
        {
            this.productField = product;
            return this;
        }



        /// <summary>
        /// Checks if Product property is set
        /// </summary>
        /// <returns>true if Product property is set</returns>
        public Boolean IsSetProduct()
        {
            return this.productField != null;
        }




        /// <summary>
        /// Gets and sets the Error property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Error")]
        public Error Error
        {
            get { return this.errorField ; }
            set { this.errorField = value; }
        }



        /// <summary>
        /// Sets the Error property
        /// </summary>
        /// <param name="error">Error property</param>
        /// <returns>this instance</returns>
        public GetCompetitivePricingForSKUResult WithError(Error error)
        {
            this.errorField = error;
            return this;
        }



        /// <summary>
        /// Checks if Error property is set
        /// </summary>
        /// <returns>true if Error property is set</returns>
        public Boolean IsSetError()
        {
            return this.errorField != null;
        }





        /// <summary>
        /// Gets and sets  the SellerSKU property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "SellerSKU")]
        public String SellerSKU
        {
            get { return this.sellerSKUField ; }
            set { this.sellerSKUField = value; }
        }



        /// <summary>
        /// Sets the SellerSKU property
        /// </summary>
        /// <param name="sellerSKU">SellerSKU property</param>
        /// <returns>this instance</returns>
        public GetCompetitivePricingForSKUResult WithSellerSKU(String sellerSKU)
        {
            this.sellerSKUField = sellerSKU;
            return this;
        }



        /// <summary>
        /// Checks if SellerSKU property is set
        /// </summary>
        /// <returns>true if SellerSKU property is set</returns>
        public Boolean IsSetSellerSKU()
        {
            return this.sellerSKUField  != null;

        }


        /// <summary>
        /// Gets and sets  the status property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "status")]
        public String status
        {
            get { return this.statusField ; }
            set { this.statusField = value; }
        }



        /// <summary>
        /// Sets the status property
        /// </summary>
        /// <param name="status">status property</param>
        /// <returns>this instance</returns>
        public GetCompetitivePricingForSKUResult Withstatus(String status)
        {
            this.statusField = status;
            return this;
        }



        /// <summary>
        /// Checks if status property is set
        /// </summary>
        /// <returns>true if status property is set</returns>
        public Boolean IsSetstatus()
        {
            return this.statusField  != null;

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
            if (IsSetProduct()) {
                Product  productObj = this.Product;
                xml.Append("<Product>");
                xml.Append(productObj.ToXMLFragment());
                xml.Append("</Product>");
            } 
            if (IsSetError()) {
                Error  errorObj = this.Error;
                xml.Append("<Error>");
                xml.Append(errorObj.ToXMLFragment());
                xml.Append("</Error>");
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