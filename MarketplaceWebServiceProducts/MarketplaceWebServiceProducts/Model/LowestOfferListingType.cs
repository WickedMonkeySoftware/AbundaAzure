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
    public class LowestOfferListingType
    {
    
        private  QualifiersType qualifiersField;
        private Decimal? numberOfOfferListingsConsideredField;

        private Decimal? sellerFeedbackCountField;

        private  PriceType priceField;
        private String multipleOffersAtLowestPriceField;


        /// <summary>
        /// Gets and sets the Qualifiers property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Qualifiers")]
        public QualifiersType Qualifiers
        {
            get { return this.qualifiersField ; }
            set { this.qualifiersField = value; }
        }



        /// <summary>
        /// Sets the Qualifiers property
        /// </summary>
        /// <param name="qualifiers">Qualifiers property</param>
        /// <returns>this instance</returns>
        public LowestOfferListingType WithQualifiers(QualifiersType qualifiers)
        {
            this.qualifiersField = qualifiers;
            return this;
        }



        /// <summary>
        /// Checks if Qualifiers property is set
        /// </summary>
        /// <returns>true if Qualifiers property is set</returns>
        public Boolean IsSetQualifiers()
        {
            return this.qualifiersField != null;
        }




        /// <summary>
        /// Gets and sets the NumberOfOfferListingsConsidered property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NumberOfOfferListingsConsidered")]
        public Decimal NumberOfOfferListingsConsidered
        {
            get { return this.numberOfOfferListingsConsideredField.GetValueOrDefault() ; }
            set { this.numberOfOfferListingsConsideredField= value; }
        }



        /// <summary>
        /// Sets the NumberOfOfferListingsConsidered property
        /// </summary>
        /// <param name="numberOfOfferListingsConsidered">NumberOfOfferListingsConsidered property</param>
        /// <returns>this instance</returns>
        public LowestOfferListingType WithNumberOfOfferListingsConsidered(Decimal numberOfOfferListingsConsidered)
        {
            this.numberOfOfferListingsConsideredField = numberOfOfferListingsConsidered;
            return this;
        }



        /// <summary>
        /// Checks if NumberOfOfferListingsConsidered property is set
        /// </summary>
        /// <returns>true if NumberOfOfferListingsConsidered property is set</returns>
        public Boolean IsSetNumberOfOfferListingsConsidered()
        {
            return  this.numberOfOfferListingsConsideredField.HasValue;

        }


        /// <summary>
        /// Gets and sets the SellerFeedbackCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerFeedbackCount")]
        public Decimal SellerFeedbackCount
        {
            get { return this.sellerFeedbackCountField.GetValueOrDefault() ; }
            set { this.sellerFeedbackCountField= value; }
        }



        /// <summary>
        /// Sets the SellerFeedbackCount property
        /// </summary>
        /// <param name="sellerFeedbackCount">SellerFeedbackCount property</param>
        /// <returns>this instance</returns>
        public LowestOfferListingType WithSellerFeedbackCount(Decimal sellerFeedbackCount)
        {
            this.sellerFeedbackCountField = sellerFeedbackCount;
            return this;
        }



        /// <summary>
        /// Checks if SellerFeedbackCount property is set
        /// </summary>
        /// <returns>true if SellerFeedbackCount property is set</returns>
        public Boolean IsSetSellerFeedbackCount()
        {
            return  this.sellerFeedbackCountField.HasValue;

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
        public LowestOfferListingType WithPrice(PriceType price)
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
        /// Gets and sets the MultipleOffersAtLowestPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MultipleOffersAtLowestPrice")]
        public String MultipleOffersAtLowestPrice
        {
            get { return this.multipleOffersAtLowestPriceField ; }
            set { this.multipleOffersAtLowestPriceField= value; }
        }



        /// <summary>
        /// Sets the MultipleOffersAtLowestPrice property
        /// </summary>
        /// <param name="multipleOffersAtLowestPrice">MultipleOffersAtLowestPrice property</param>
        /// <returns>this instance</returns>
        public LowestOfferListingType WithMultipleOffersAtLowestPrice(String multipleOffersAtLowestPrice)
        {
            this.multipleOffersAtLowestPriceField = multipleOffersAtLowestPrice;
            return this;
        }



        /// <summary>
        /// Checks if MultipleOffersAtLowestPrice property is set
        /// </summary>
        /// <returns>true if MultipleOffersAtLowestPrice property is set</returns>
        public Boolean IsSetMultipleOffersAtLowestPrice()
        {
            return  this.multipleOffersAtLowestPriceField != null;

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
            if (IsSetQualifiers()) {
                QualifiersType  qualifiersObj = this.Qualifiers;
                xml.Append("<Qualifiers>");
                xml.Append(qualifiersObj.ToXMLFragment());
                xml.Append("</Qualifiers>");
            } 
            if (IsSetNumberOfOfferListingsConsidered()) {
                xml.Append("<NumberOfOfferListingsConsidered>");
                xml.Append(this.NumberOfOfferListingsConsidered);
                xml.Append("</NumberOfOfferListingsConsidered>");
            }
            if (IsSetSellerFeedbackCount()) {
                xml.Append("<SellerFeedbackCount>");
                xml.Append(this.SellerFeedbackCount);
                xml.Append("</SellerFeedbackCount>");
            }
            if (IsSetPrice()) {
                PriceType  priceObj = this.Price;
                xml.Append("<Price>");
                xml.Append(priceObj.ToXMLFragment());
                xml.Append("</Price>");
            } 
            if (IsSetMultipleOffersAtLowestPrice()) {
                xml.Append("<MultipleOffersAtLowestPrice>");
                xml.Append(EscapeXML(this.MultipleOffersAtLowestPrice));
                xml.Append("</MultipleOffersAtLowestPrice>");
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