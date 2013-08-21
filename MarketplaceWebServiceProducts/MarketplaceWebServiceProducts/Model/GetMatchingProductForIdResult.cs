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
    public class GetMatchingProductForIdResult
    {
    
        private  String idField;
        private  String idTypeField;
        private  String statusField;
        private  ProductList productsField;
        private  Error errorField;

        /// <summary>
        /// Gets and sets the Products property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Products")]
        public ProductList Products
        {
            get { return this.productsField ; }
            set { this.productsField = value; }
        }



        /// <summary>
        /// Sets the Products property
        /// </summary>
        /// <param name="products">Products property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductForIdResult WithProducts(ProductList products)
        {
            this.productsField = products;
            return this;
        }



        /// <summary>
        /// Checks if Products property is set
        /// </summary>
        /// <returns>true if Products property is set</returns>
        public Boolean IsSetProducts()
        {
            return this.productsField != null;
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
        public GetMatchingProductForIdResult WithError(Error error)
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
        /// Gets and sets  the Id property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "Id")]
        public String Id
        {
            get { return this.idField ; }
            set { this.idField = value; }
        }



        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">Id property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductForIdResult WithId(String id)
        {
            this.idField = id;
            return this;
        }



        /// <summary>
        /// Checks if Id property is set
        /// </summary>
        /// <returns>true if Id property is set</returns>
        public Boolean IsSetId()
        {
            return this.idField  != null;

        }


        /// <summary>
        /// Gets and sets  the IdType property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "IdType")]
        public String IdType
        {
            get { return this.idTypeField ; }
            set { this.idTypeField = value; }
        }



        /// <summary>
        /// Sets the IdType property
        /// </summary>
        /// <param name="idType">IdType property</param>
        /// <returns>this instance</returns>
        public GetMatchingProductForIdResult WithIdType(String idType)
        {
            this.idTypeField = idType;
            return this;
        }



        /// <summary>
        /// Checks if IdType property is set
        /// </summary>
        /// <returns>true if IdType property is set</returns>
        public Boolean IsSetIdType()
        {
            return this.idTypeField  != null;

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
        public GetMatchingProductForIdResult Withstatus(String status)
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
            if (IsSetProducts()) {
                ProductList  productsObj = this.Products;
                xml.Append("<Products>");
                xml.Append(productsObj.ToXMLFragment());
                xml.Append("</Products>");
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