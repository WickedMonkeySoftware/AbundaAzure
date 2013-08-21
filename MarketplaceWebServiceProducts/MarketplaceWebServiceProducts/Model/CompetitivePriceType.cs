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
    public class CompetitivePriceType
    {
    
        private  String conditionField;
        private  String subconditionField;
        private  Boolean? belongsToRequesterField;
        private String competitivePriceIdField;

        private  PriceType priceField;

        /// <summary>
        /// Gets and sets the CompetitivePriceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CompetitivePriceId")]
        public String CompetitivePriceId
        {
            get { return this.competitivePriceIdField ; }
            set { this.competitivePriceIdField= value; }
        }



        /// <summary>
        /// Sets the CompetitivePriceId property
        /// </summary>
        /// <param name="competitivePriceId">CompetitivePriceId property</param>
        /// <returns>this instance</returns>
        public CompetitivePriceType WithCompetitivePriceId(String competitivePriceId)
        {
            this.competitivePriceIdField = competitivePriceId;
            return this;
        }



        /// <summary>
        /// Checks if CompetitivePriceId property is set
        /// </summary>
        /// <returns>true if CompetitivePriceId property is set</returns>
        public Boolean IsSetCompetitivePriceId()
        {
            return  this.competitivePriceIdField != null;

        }


        /// <summary>
        /// Gets and sets the Price property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Price")]
        public PriceType Price
        {
            get { return this.priceField ; }
            set { this.priceField = value; }
        }



        /// <summary>
        /// Sets the Price property
        /// </summary>
        /// <param name="price">Price property</param>
        /// <returns>this instance</returns>
        public CompetitivePriceType WithPrice(PriceType price)
        {
            this.priceField = price;
            return this;
        }



        /// <summary>
        /// Checks if Price property is set
        /// </summary>
        /// <returns>true if Price property is set</returns>
        public Boolean IsSetPrice()
        {
            return this.priceField != null;
        }





        /// <summary>
        /// Gets and sets  the condition property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "condition")]
        public String condition
        {
            get { return this.conditionField ; }
            set { this.conditionField = value; }
        }



        /// <summary>
        /// Sets the condition property
        /// </summary>
        /// <param name="condition">condition property</param>
        /// <returns>this instance</returns>
        public CompetitivePriceType Withcondition(String condition)
        {
            this.conditionField = condition;
            return this;
        }



        /// <summary>
        /// Checks if condition property is set
        /// </summary>
        /// <returns>true if condition property is set</returns>
        public Boolean IsSetcondition()
        {
            return this.conditionField  != null;

        }


        /// <summary>
        /// Gets and sets  the subcondition property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "subcondition")]
        public String subcondition
        {
            get { return this.subconditionField ; }
            set { this.subconditionField = value; }
        }



        /// <summary>
        /// Sets the subcondition property
        /// </summary>
        /// <param name="subcondition">subcondition property</param>
        /// <returns>this instance</returns>
        public CompetitivePriceType Withsubcondition(String subcondition)
        {
            this.subconditionField = subcondition;
            return this;
        }



        /// <summary>
        /// Checks if subcondition property is set
        /// </summary>
        /// <returns>true if subcondition property is set</returns>
        public Boolean IsSetsubcondition()
        {
            return this.subconditionField  != null;

        }


        /// <summary>
        /// Gets and sets  the belongsToRequester property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "belongsToRequester")]
        public Boolean belongsToRequester
        {
            get { return this.belongsToRequesterField.Value; }
            set { this.belongsToRequesterField = value; }
        }



        /// <summary>
        /// Sets the belongsToRequester property
        /// </summary>
        /// <param name="belongsToRequester">belongsToRequester property</param>
        /// <returns>this instance</returns>
        public CompetitivePriceType WithbelongsToRequester(Boolean belongsToRequester)
        {
            this.belongsToRequesterField = belongsToRequester;
            return this;
        }



        /// <summary>
        /// Checks if belongsToRequester property is set
        /// </summary>
        /// <returns>true if belongsToRequester property is set</returns>
        public Boolean IsSetbelongsToRequester()
        {
            return this.belongsToRequesterField.HasValue;

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
            if (IsSetCompetitivePriceId()) {
                xml.Append("<CompetitivePriceId>");
                xml.Append(EscapeXML(this.CompetitivePriceId));
                xml.Append("</CompetitivePriceId>");
            }
            if (IsSetPrice()) {
                PriceType  priceObj = this.Price;
                xml.Append("<Price>");
                xml.Append(priceObj.ToXMLFragment());
                xml.Append("</Price>");
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
