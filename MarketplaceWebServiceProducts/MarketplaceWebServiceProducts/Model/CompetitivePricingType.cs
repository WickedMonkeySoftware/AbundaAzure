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
    public class CompetitivePricingType
    {
    
        private  CompetitivePriceList competitivePricesField;
        private  NumberOfOfferListingsList numberOfOfferListingsField;
        private  MoneyType tradeInValueField;

        /// <summary>
        /// Gets and sets the CompetitivePrices property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CompetitivePrices")]
        public CompetitivePriceList CompetitivePrices
        {
            get { return this.competitivePricesField ; }
            set { this.competitivePricesField = value; }
        }



        /// <summary>
        /// Sets the CompetitivePrices property
        /// </summary>
        /// <param name="competitivePrices">CompetitivePrices property</param>
        /// <returns>this instance</returns>
        public CompetitivePricingType WithCompetitivePrices(CompetitivePriceList competitivePrices)
        {
            this.competitivePricesField = competitivePrices;
            return this;
        }



        /// <summary>
        /// Checks if CompetitivePrices property is set
        /// </summary>
        /// <returns>true if CompetitivePrices property is set</returns>
        public Boolean IsSetCompetitivePrices()
        {
            return this.competitivePricesField != null;
        }




        /// <summary>
        /// Gets and sets the NumberOfOfferListings property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NumberOfOfferListings")]
        public NumberOfOfferListingsList NumberOfOfferListings
        {
            get { return this.numberOfOfferListingsField ; }
            set { this.numberOfOfferListingsField = value; }
        }



        /// <summary>
        /// Sets the NumberOfOfferListings property
        /// </summary>
        /// <param name="numberOfOfferListings">NumberOfOfferListings property</param>
        /// <returns>this instance</returns>
        public CompetitivePricingType WithNumberOfOfferListings(NumberOfOfferListingsList numberOfOfferListings)
        {
            this.numberOfOfferListingsField = numberOfOfferListings;
            return this;
        }



        /// <summary>
        /// Checks if NumberOfOfferListings property is set
        /// </summary>
        /// <returns>true if NumberOfOfferListings property is set</returns>
        public Boolean IsSetNumberOfOfferListings()
        {
            return this.numberOfOfferListingsField != null;
        }




        /// <summary>
        /// Gets and sets the TradeInValue property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TradeInValue")]
        public MoneyType TradeInValue
        {
            get { return this.tradeInValueField ; }
            set { this.tradeInValueField = value; }
        }



        /// <summary>
        /// Sets the TradeInValue property
        /// </summary>
        /// <param name="tradeInValue">TradeInValue property</param>
        /// <returns>this instance</returns>
        public CompetitivePricingType WithTradeInValue(MoneyType tradeInValue)
        {
            this.tradeInValueField = tradeInValue;
            return this;
        }



        /// <summary>
        /// Checks if TradeInValue property is set
        /// </summary>
        /// <returns>true if TradeInValue property is set</returns>
        public Boolean IsSetTradeInValue()
        {
            return this.tradeInValueField != null;
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
            if (IsSetCompetitivePrices()) {
                CompetitivePriceList  competitivePricesObj = this.CompetitivePrices;
                xml.Append("<CompetitivePrices>");
                xml.Append(competitivePricesObj.ToXMLFragment());
                xml.Append("</CompetitivePrices>");
            } 
            if (IsSetNumberOfOfferListings()) {
                NumberOfOfferListingsList  numberOfOfferListingsObj = this.NumberOfOfferListings;
                xml.Append("<NumberOfOfferListings>");
                xml.Append(numberOfOfferListingsObj.ToXMLFragment());
                xml.Append("</NumberOfOfferListings>");
            } 
            if (IsSetTradeInValue()) {
                MoneyType  tradeInValueObj = this.TradeInValue;
                xml.Append("<TradeInValue>");
                xml.Append(tradeInValueObj.ToXMLFragment());
                xml.Append("</TradeInValue>");
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