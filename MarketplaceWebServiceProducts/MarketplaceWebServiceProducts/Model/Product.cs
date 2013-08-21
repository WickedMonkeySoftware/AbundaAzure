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
    public class Product
    {
    
        private  IdentifierType identifiersField;
        private  AttributeSetList attributeSetsField;
        private  RelationshipList relationshipsField;
        private  CompetitivePricingType competitivePricingField;
        private  SalesRankList salesRankingsField;
        private  LowestOfferListingList lowestOfferListingsField;
        private  OffersList offersField;

        /// <summary>
        /// Gets and sets the Identifiers property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Identifiers")]
        public IdentifierType Identifiers
        {
            get { return this.identifiersField ; }
            set { this.identifiersField = value; }
        }



        /// <summary>
        /// Sets the Identifiers property
        /// </summary>
        /// <param name="identifiers">Identifiers property</param>
        /// <returns>this instance</returns>
        public Product WithIdentifiers(IdentifierType identifiers)
        {
            this.identifiersField = identifiers;
            return this;
        }



        /// <summary>
        /// Checks if Identifiers property is set
        /// </summary>
        /// <returns>true if Identifiers property is set</returns>
        public Boolean IsSetIdentifiers()
        {
            return this.identifiersField != null;
        }




        /// <summary>
        /// Gets and sets the AttributeSets property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeSets")]
        public AttributeSetList AttributeSets
        {
            get { return this.attributeSetsField ; }
            set { this.attributeSetsField = value; }
        }



        /// <summary>
        /// Sets the AttributeSets property
        /// </summary>
        /// <param name="attributeSets">AttributeSets property</param>
        /// <returns>this instance</returns>
        public Product WithAttributeSets(AttributeSetList attributeSets)
        {
            this.attributeSetsField = attributeSets;
            return this;
        }



        /// <summary>
        /// Checks if AttributeSets property is set
        /// </summary>
        /// <returns>true if AttributeSets property is set</returns>
        public Boolean IsSetAttributeSets()
        {
            return this.attributeSetsField != null;
        }




        /// <summary>
        /// Gets and sets the Relationships property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Relationships")]
        public RelationshipList Relationships
        {
            get { return this.relationshipsField ; }
            set { this.relationshipsField = value; }
        }



        /// <summary>
        /// Sets the Relationships property
        /// </summary>
        /// <param name="relationships">Relationships property</param>
        /// <returns>this instance</returns>
        public Product WithRelationships(RelationshipList relationships)
        {
            this.relationshipsField = relationships;
            return this;
        }



        /// <summary>
        /// Checks if Relationships property is set
        /// </summary>
        /// <returns>true if Relationships property is set</returns>
        public Boolean IsSetRelationships()
        {
            return this.relationshipsField != null;
        }




        /// <summary>
        /// Gets and sets the CompetitivePricing property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CompetitivePricing")]
        public CompetitivePricingType CompetitivePricing
        {
            get { return this.competitivePricingField ; }
            set { this.competitivePricingField = value; }
        }



        /// <summary>
        /// Sets the CompetitivePricing property
        /// </summary>
        /// <param name="competitivePricing">CompetitivePricing property</param>
        /// <returns>this instance</returns>
        public Product WithCompetitivePricing(CompetitivePricingType competitivePricing)
        {
            this.competitivePricingField = competitivePricing;
            return this;
        }



        /// <summary>
        /// Checks if CompetitivePricing property is set
        /// </summary>
        /// <returns>true if CompetitivePricing property is set</returns>
        public Boolean IsSetCompetitivePricing()
        {
            return this.competitivePricingField != null;
        }




        /// <summary>
        /// Gets and sets the SalesRankings property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SalesRankings")]
        public SalesRankList SalesRankings
        {
            get { return this.salesRankingsField ; }
            set { this.salesRankingsField = value; }
        }



        /// <summary>
        /// Sets the SalesRankings property
        /// </summary>
        /// <param name="salesRankings">SalesRankings property</param>
        /// <returns>this instance</returns>
        public Product WithSalesRankings(SalesRankList salesRankings)
        {
            this.salesRankingsField = salesRankings;
            return this;
        }



        /// <summary>
        /// Checks if SalesRankings property is set
        /// </summary>
        /// <returns>true if SalesRankings property is set</returns>
        public Boolean IsSetSalesRankings()
        {
            return this.salesRankingsField != null;
        }




        /// <summary>
        /// Gets and sets the LowestOfferListings property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LowestOfferListings")]
        public LowestOfferListingList LowestOfferListings
        {
            get { return this.lowestOfferListingsField ; }
            set { this.lowestOfferListingsField = value; }
        }



        /// <summary>
        /// Sets the LowestOfferListings property
        /// </summary>
        /// <param name="lowestOfferListings">LowestOfferListings property</param>
        /// <returns>this instance</returns>
        public Product WithLowestOfferListings(LowestOfferListingList lowestOfferListings)
        {
            this.lowestOfferListingsField = lowestOfferListings;
            return this;
        }



        /// <summary>
        /// Checks if LowestOfferListings property is set
        /// </summary>
        /// <returns>true if LowestOfferListings property is set</returns>
        public Boolean IsSetLowestOfferListings()
        {
            return this.lowestOfferListingsField != null;
        }




        /// <summary>
        /// Gets and sets the Offers property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Offers")]
        public OffersList Offers
        {
            get { return this.offersField ; }
            set { this.offersField = value; }
        }



        /// <summary>
        /// Sets the Offers property
        /// </summary>
        /// <param name="offers">Offers property</param>
        /// <returns>this instance</returns>
        public Product WithOffers(OffersList offers)
        {
            this.offersField = offers;
            return this;
        }



        /// <summary>
        /// Checks if Offers property is set
        /// </summary>
        /// <returns>true if Offers property is set</returns>
        public Boolean IsSetOffers()
        {
            return this.offersField != null;
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
            if (IsSetIdentifiers()) {
                IdentifierType  identifiersObj = this.Identifiers;
                xml.Append("<Identifiers>");
                xml.Append(identifiersObj.ToXMLFragment());
                xml.Append("</Identifiers>");
            } 
            if (IsSetAttributeSets()) {
                AttributeSetList  attributeSetsObj = this.AttributeSets;
                xml.Append("<AttributeSets>");
                xml.Append(attributeSetsObj.ToXMLFragment());
                xml.Append("</AttributeSets>");
            } 
            if (IsSetRelationships()) {
                RelationshipList  relationshipsObj = this.Relationships;
                xml.Append("<Relationships>");
                xml.Append(relationshipsObj.ToXMLFragment());
                xml.Append("</Relationships>");
            } 
            if (IsSetCompetitivePricing()) {
                CompetitivePricingType  competitivePricingObj = this.CompetitivePricing;
                xml.Append("<CompetitivePricing>");
                xml.Append(competitivePricingObj.ToXMLFragment());
                xml.Append("</CompetitivePricing>");
            } 
            if (IsSetSalesRankings()) {
                SalesRankList  salesRankingsObj = this.SalesRankings;
                xml.Append("<SalesRankings>");
                xml.Append(salesRankingsObj.ToXMLFragment());
                xml.Append("</SalesRankings>");
            } 
            if (IsSetLowestOfferListings()) {
                LowestOfferListingList  lowestOfferListingsObj = this.LowestOfferListings;
                xml.Append("<LowestOfferListings>");
                xml.Append(lowestOfferListingsObj.ToXMLFragment());
                xml.Append("</LowestOfferListings>");
            } 
            if (IsSetOffers()) {
                OffersList  offersObj = this.Offers;
                xml.Append("<Offers>");
                xml.Append(offersObj.ToXMLFragment());
                xml.Append("</Offers>");
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