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
using System.Reflection;
using System.Web;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Globalization;
using System.Xml.Serialization;
using System.Collections.Generic;
using MarketplaceWebServiceProducts.Model;
using MarketplaceWebServiceProducts;


namespace MarketplaceWebServiceProducts
{


   /**

    *
    * MarketplaceWebServiceProductsClient is an implementation of MarketplaceWebServiceProducts
    *
    */
    public class MarketplaceWebServiceProductsClient : MarketplaceWebServiceProducts
    {

        private String awsAccessKeyId = null;
        private String awsSecretAccessKey = null;
        private MarketplaceWebServiceProductsConfig config = null;
        private const String REQUEST_THROTTLED_ERROR_CODE = "RequestThrottled";

        /// <summary>
        /// Constructs MarketplaceWebServiceProductsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="applicationName">Your application's name, e.g. "MyMWSApp"</param>
        /// <param name="applicationVersion">Your application's version, e.g. "1.0"</param>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">configuration</param>
        public MarketplaceWebServiceProductsClient(
            String applicationName, 
            String applicationVersion, 
            String awsAccessKeyId, 
            String awsSecretAccessKey, 
            MarketplaceWebServiceProductsConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
            config.SetUserAgent(applicationName, applicationVersion);
        }


        // Public API ------------------------------------------------------------//

        
        /// <summary>
        /// Get Matching Product 
        /// </summary>
        /// <param name="request">Get Matching Product  request</param>
        /// <returns>Get Matching Product  Response from the service</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given ASIN.
        /// 
        /// </remarks>
        public GetMatchingProductResponse GetMatchingProduct(GetMatchingProductRequest request)
        {
            return Invoke<GetMatchingProductResponse>(ConvertGetMatchingProduct(request));
        }

        
        /// <summary>
        /// Get Lowest Offer Listings For ASIN 
        /// </summary>
        /// <param name="request">Get Lowest Offer Listings For ASIN  request</param>
        /// <returns>Get Lowest Offer Listings For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets some of the lowest prices based on the product identified by the given
        /// MarketplaceId and ASIN.
        /// 
        /// </remarks>
        public GetLowestOfferListingsForASINResponse GetLowestOfferListingsForASIN(GetLowestOfferListingsForASINRequest request)
        {
            return Invoke<GetLowestOfferListingsForASINResponse>(ConvertGetLowestOfferListingsForASIN(request));
        }

        
        /// <summary>
        /// Get Service Status 
        /// </summary>
        /// <param name="request">Get Service Status  request</param>
        /// <returns>Get Service Status  Response from the service</returns>
        /// <remarks>
        /// Returns the service status of a particular MWS API section. The operation
        /// takes no input.
        /// All API sections within the API are required to implement this operation.
        /// 
        /// </remarks>
        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return Invoke<GetServiceStatusResponse>(ConvertGetServiceStatus(request));
        }

        
        /// <summary>
        /// Get Matching Product For Id 
        /// </summary>
        /// <param name="request">Get Matching Product For Id  request</param>
        /// <returns>Get Matching Product For Id  Response from the service</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given Identifier list. Identifer type can be one of [SKU|ASIN|UPC|EAN|ISBN|GTIN|JAN]
        /// 
        /// </remarks>
        public GetMatchingProductForIdResponse GetMatchingProductForId(GetMatchingProductForIdRequest request)
        {
            return Invoke<GetMatchingProductForIdResponse>(ConvertGetMatchingProductForId(request));
        }

        
        /// <summary>
        /// Get My Price For SKU 
        /// </summary>
        /// <param name="request">Get My Price For SKU  request</param>
        /// <returns>Get My Price For SKU  Response from the service</returns>
        /// <remarks>
        /// GetMatchingProduct will return the details (attributes) for the
        /// given Identifier list. Identifer type can be one of [SKU|ASIN|UPC|EAN|ISBN|GTIN|JAN]
        /// 
        /// </remarks>
        public GetMyPriceForSKUResponse GetMyPriceForSKU(GetMyPriceForSKURequest request)
        {
            return Invoke<GetMyPriceForSKUResponse>(ConvertGetMyPriceForSKU(request));
        }

        
        /// <summary>
        /// List Matching Products 
        /// </summary>
        /// <param name="request">List Matching Products  request</param>
        /// <returns>List Matching Products  Response from the service</returns>
        /// <remarks>
        /// ListMatchingProducts can be used to
        /// find products that match the given criteria.
        /// 
        /// </remarks>
        public ListMatchingProductsResponse ListMatchingProducts(ListMatchingProductsRequest request)
        {
            return Invoke<ListMatchingProductsResponse>(ConvertListMatchingProducts(request));
        }

        
        /// <summary>
        /// Get Competitive Pricing For SKU 
        /// </summary>
        /// <param name="request">Get Competitive Pricing For SKU  request</param>
        /// <returns>Get Competitive Pricing For SKU  Response from the service</returns>
        /// <remarks>
        /// Gets competitive pricing and related information for a product identified by
        /// the SellerId and SKU.
        /// 
        /// </remarks>
        public GetCompetitivePricingForSKUResponse GetCompetitivePricingForSKU(GetCompetitivePricingForSKURequest request)
        {
            return Invoke<GetCompetitivePricingForSKUResponse>(ConvertGetCompetitivePricingForSKU(request));
        }

        
        /// <summary>
        /// Get Competitive Pricing For ASIN 
        /// </summary>
        /// <param name="request">Get Competitive Pricing For ASIN  request</param>
        /// <returns>Get Competitive Pricing For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets competitive pricing and related information for a product identified by
        /// the MarketplaceId and ASIN.
        /// 
        /// </remarks>
        public GetCompetitivePricingForASINResponse GetCompetitivePricingForASIN(GetCompetitivePricingForASINRequest request)
        {
            return Invoke<GetCompetitivePricingForASINResponse>(ConvertGetCompetitivePricingForASIN(request));
        }

        
        /// <summary>
        /// Get Product Categories For SKU 
        /// </summary>
        /// <param name="request">Get Product Categories For SKU  request</param>
        /// <returns>Get Product Categories For SKU  Response from the service</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the SellerId and SKU.
        /// 
        /// </remarks>
        public GetProductCategoriesForSKUResponse GetProductCategoriesForSKU(GetProductCategoriesForSKURequest request)
        {
            return Invoke<GetProductCategoriesForSKUResponse>(ConvertGetProductCategoriesForSKU(request));
        }

        
        /// <summary>
        /// Get My Price For ASIN 
        /// </summary>
        /// <param name="request">Get My Price For ASIN  request</param>
        /// <returns>Get My Price For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the SellerId and SKU.
        /// 
        /// </remarks>
        public GetMyPriceForASINResponse GetMyPriceForASIN(GetMyPriceForASINRequest request)
        {
            return Invoke<GetMyPriceForASINResponse>(ConvertGetMyPriceForASIN(request));
        }

        
        /// <summary>
        /// Get Lowest Offer Listings For SKU 
        /// </summary>
        /// <param name="request">Get Lowest Offer Listings For SKU  request</param>
        /// <returns>Get Lowest Offer Listings For SKU  Response from the service</returns>
        /// <remarks>
        /// Gets some of the lowest prices based on the product identified by the given
        /// SellerId and SKU.
        /// 
        /// </remarks>
        public GetLowestOfferListingsForSKUResponse GetLowestOfferListingsForSKU(GetLowestOfferListingsForSKURequest request)
        {
            return Invoke<GetLowestOfferListingsForSKUResponse>(ConvertGetLowestOfferListingsForSKU(request));
        }

        
        /// <summary>
        /// Get Product Categories For ASIN 
        /// </summary>
        /// <param name="request">Get Product Categories For ASIN  request</param>
        /// <returns>Get Product Categories For ASIN  Response from the service</returns>
        /// <remarks>
        /// Gets categories information for a product identified by
        /// the MarketplaceId and ASIN.
        /// 
        /// </remarks>
        public GetProductCategoriesForASINResponse GetProductCategoriesForASIN(GetProductCategoriesForASINRequest request)
        {
            return Invoke<GetProductCategoriesForASINResponse>(ConvertGetProductCategoriesForASIN(request));
        }

        // Private API ------------------------------------------------------------//

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from MarketplaceWebServiceProductsConfig instance
         */
        private HttpWebRequest ConfigureWebRequest(int contentLength)
        {
            HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;

            if (config.IsSetProxyHost())
            {
                request.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            }
            request.UserAgent = config.UserAgent;
            request.Method = "POST";
            request.Timeout = 50000;
            request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            request.ContentLength = contentLength;

            return request;
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T>(IDictionary<String, String> parameters)
        {
            String actionName = parameters["Action"];
            T response = default(T);
            String responseBody = null;
            HttpStatusCode statusCode = default(HttpStatusCode);
            ResponseHeaderMetadata rhm = null;
            if (String.IsNullOrEmpty(config.ServiceURL))
            {
                throw new MarketplaceWebServiceProductsException(
                    new ArgumentException(
                        "Missing serviceURL configuration value. You may obtain a list of valid MWS URLs by consulting the MWS Developer's Guide, or reviewing the sample code published along side this library."));
            }

            /* Add required request parameters */
            AddRequiredParameters(parameters);

            String queryString = GetParametersAsString(parameters);

            byte[] requestData = new UTF8Encoding().GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            do
            {
                HttpWebRequest request = ConfigureWebRequest(requestData.Length);
                /* Submit the request and read response body */
                try
                {
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(requestData, 0, requestData.Length);
                    }
                    using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
                    {
                        statusCode = httpResponse.StatusCode;


                        rhm = new ResponseHeaderMetadata(
                          httpResponse.GetResponseHeader("x-mws-request-id"),
                          httpResponse.GetResponseHeader("x-mws-response-context"),
                          httpResponse.GetResponseHeader("x-mws-timestamp"));

                        StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
                        responseBody = reader.ReadToEnd();
                    }
                    /* Attempt to deserialize response into <Action> Response type */
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (StringReader responseReader = new StringReader(responseBody))
                    {
                        response = (T)serializer.Deserialize(responseReader);

                        PropertyInfo pi = typeof(T).GetProperty("ResponseHeaderMetadata");
                        pi.SetValue(response, rhm, null);
                    }
                    shouldRetry = false;
                }
                /* Web exception is thrown on unsucessful responses */
                catch (WebException we)
                {
                    shouldRetry = false;
                    using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            throw new MarketplaceWebServiceProductsException(we);
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }

                    /* Attempt to deserialize response into ErrorResponse type */
                    using (StringReader responseReader = new StringReader(responseBody))
                    {
                        try
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(ErrorResponse));
                            ErrorResponse errorResponse = (ErrorResponse)serializer.Deserialize(responseReader);
                            Error error = errorResponse.Error[0];

                            bool retriableError =
                                (statusCode == HttpStatusCode.InternalServerError ||
                                 statusCode == HttpStatusCode.ServiceUnavailable);

                            retriableError = retriableError && !(REQUEST_THROTTLED_ERROR_CODE.Equals(error.Code));
                            if (retriableError && retries < config.MaxErrorRetry)
                            {
                                shouldRetry = true;
                                PauseOnRetry(++retries, statusCode, rhm);
                                continue;
                            }
                            else
                            {
                                shouldRetry = false;
                            }

                            /* Throw formatted exception with information available from the error response */
                            throw new MarketplaceWebServiceProductsException(
                                error.Message,
                                statusCode,
                                error.Code,
                                error.Type,
                                errorResponse.RequestId,
                                errorResponse.ToXML(),
                                rhm);
                        }
                        catch (MarketplaceWebServiceProductsException mwsErr)
                        {
                            throw mwsErr;
                        }
                        catch (Exception e)
                        {
                            throw ReportAnyErrors(responseBody, statusCode, rhm, e);
                        }
                    }
                }

                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception e)
                {
                    throw new MarketplaceWebServiceProductsException(e);
                }
            } while (shouldRetry);

            return response;
        }


        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private MarketplaceWebServiceProductsException ReportAnyErrors(String responseBody, HttpStatusCode status, ResponseHeaderMetadata rhm, Exception e)
        {

            MarketplaceWebServiceProductsException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(responseBody, "<RequestId>(.*)</RequestId>.*<Error>" +
                        "<Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?", RegexOptions.Multiline);
                Match errorMatcherTwo = Regex.Match(responseBody, "<Error><Code>(.*)</Code><Message>(.*)" +
                        "</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>", RegexOptions.Multiline);

                if (errorMatcherOne.Success)
                {
                    String requestId = errorMatcherOne.Groups[1].Value;
                    String code = errorMatcherOne.Groups[2].Value;
                    String message = errorMatcherOne.Groups[3].Value;

                    ex = new MarketplaceWebServiceProductsException(message, status, code, "Unknown", requestId, responseBody, rhm);

                }
                else if (errorMatcherTwo.Success)
                {
                    String code = errorMatcherTwo.Groups[1].Value;
                    String message = errorMatcherTwo.Groups[2].Value;
                    String requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new MarketplaceWebServiceProductsException(message, status, code, "Unknown", requestId, responseBody, rhm);
                }
                else
                {
                    ex = new MarketplaceWebServiceProductsException("Internal Error", status, rhm);
                }
            }
            else
            {
                ex = new MarketplaceWebServiceProductsException("Internal Error", status, rhm);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private void PauseOnRetry(int retries, HttpStatusCode status, ResponseHeaderMetadata rhm)
        {
            if (retries <= config.MaxErrorRetry)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new MarketplaceWebServiceProductsException("Maximum number of retry attempts reached : " + (retries - 1), status, rhm);
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<String, String> parameters)
        {
            parameters.Add("AWSAccessKeyId", this.awsAccessKeyId);
            parameters.Add("Timestamp", GetFormattedTimestamp());
            parameters.Add("Version", config.ServiceVersion);
            parameters.Add("SignatureVersion", config.SignatureVersion);
            parameters.Add("Signature", SignParameters(parameters, this.awsSecretAccessKey));
        }

        /**
         * Convert Dictionary of paremeters to Url encoded query string
         */
        private string GetParametersAsString(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            foreach (String key in (IEnumerable<String>)parameters.Keys)
            {
                String value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(UrlEncode(value, false));
                    data.Append('&');
                }
            }
            String result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /**
         * Computes RFC 2104-compliant HMAC signature for request parameters
         * Implements AWS Signature, as per following spec:
         *
         * If Signature Version is 0, it signs concatenated Action and Timestamp
         *
         * If Signature Version is 1, it performs the following:
         *
         * Sorts all  parameters (including SignatureVersion and excluding Signature,
         * the value of which is being created), ignoring case.
         *
         * Iterate over the sorted list and append the parameter name (in original case)
         * and then its value. It will not URL-encode the parameter values before
         * constructing this string. There are no separators.
         *
         * If Signature Version is 2, string to sign is based on following:
         *
         *    1. The HTTP Request Method followed by an ASCII newline (%0A)
         *    2. The HTTP Host header in the form of lowercase host, followed by an ASCII newline.
         *    3. The URL encoded HTTP absolute path component of the URI
         *       (up to but not including the query string parameters);
         *       if this is empty use a forward '/'. This parameter is followed by an ASCII newline.
         *    4. The concatenation of all query string components (names and values)
         *       as UTF-8 characters which are URL encoded as per RFC 3986
         *       (hex characters MUST be uppercase), sorted using lexicographic byte ordering.
         *       Parameter names are separated from their values by the '=' character
         *       (ASCII character 61), even if the value is empty.
         *       Pairs of parameter and values are separated by the '&' character (ASCII code 38).
         *
         */
        private String SignParameters(IDictionary<String, String> parameters, String key)
        {
            String signatureVersion = parameters["SignatureVersion"];

            KeyedHashAlgorithm algorithm = new HMACSHA1();

            String stringToSign = null;
            if ("0".Equals(signatureVersion))
            {
                stringToSign = CalculateStringToSignV0(parameters);
            }
            else if ("1".Equals(signatureVersion))
            {
                stringToSign = CalculateStringToSignV1(parameters);
            }
            else if ("2".Equals(signatureVersion))
            {
                String signatureMethod = config.SignatureMethod;
                algorithm = KeyedHashAlgorithm.Create(signatureMethod.ToUpper());
                parameters.Add("SignatureMethod", signatureMethod);
                stringToSign = CalculateStringToSignV2(parameters);
            }
            else
            {
                throw new Exception("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private String CalculateStringToSignV0(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            return data.Append(parameters["Action"]).Append(parameters["Timestamp"]).ToString();

        }

        private String CalculateStringToSignV1(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            IDictionary<String, String> sorted =
              new SortedDictionary<String, String>(parameters, StringComparer.OrdinalIgnoreCase);
            foreach (KeyValuePair<String, String> pair in sorted)
            {
                if (pair.Value != null)
                {
                    data.Append(pair.Key);
                    data.Append(pair.Value);
                }
            }
            return data.ToString();
        }

        private String CalculateStringToSignV2(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            IDictionary<String, String> sorted =
                  new SortedDictionary<String, String>(parameters, StringComparer.Ordinal);
            data.Append("POST");
            data.Append("\n");
            Uri endpoint = new Uri(config.ServiceURL);

            data.Append(endpoint.Host);
            if (endpoint.Port != 80 && endpoint.Port != 443)
            {
                data.Append(":");
                data.Append(endpoint.Port);
            }
            data.Append("\n");
            String uri = endpoint.AbsolutePath;
            if (String.IsNullOrEmpty(uri))
            {
                uri = "/";
            }
            data.Append(UrlEncode(uri, true));
            data.Append("\n");
            foreach (KeyValuePair<String, String> pair in sorted)
            {
                if (pair.Value != null)
                {
                    data.Append(UrlEncode(pair.Key, false));
                    data.Append("=");
                    data.Append(UrlEncode(pair.Value, false));
                    data.Append("&");
                }

            }

            String result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        private String UrlEncode(String data, bool path)
        {
            StringBuilder encoded = new StringBuilder();
            String unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~" + (path ? "/" : "");

            foreach (char symbol in System.Text.Encoding.UTF8.GetBytes(data))
            {
                if (unreservedChars.IndexOf(symbol) != -1)
                {
                    encoded.Append(symbol);
            }
            else
            {
                    encoded.Append("%" + String.Format("{0:X2}", (int)symbol));
            }
            }

            return encoded.ToString();

        }

        /**
         * Computes RFC 2104-compliant HMAC signature.
         */
        private String Sign(String data, String key, KeyedHashAlgorithm algorithm)
        {
            Encoding encoding = new UTF8Encoding();
            algorithm.Key = encoding.GetBytes(key);
            return Convert.ToBase64String(algorithm.ComputeHash(
                encoding.GetBytes(data.ToCharArray())));
        }


        /**
         * Formats date as ISO 8601 timestamp
         */
        private String GetFormattedTimestamp()
        {
            DateTime dateTime = DateTime.Now;
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day,
                                 dateTime.Hour, dateTime.Minute, dateTime.Second,
                                 dateTime.Millisecond
                                 , DateTimeKind.Local
                               ).ToUniversalTime().ToString("yyyy-MM-dd\\THH:mm:ss.fff\\Z",
                                CultureInfo.InvariantCulture);
        }

                                                
        /**
         * Convert GetMatchingProductRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetMatchingProduct(GetMatchingProductRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetMatchingProduct");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetASINList())
            {
                ASINListType  getMatchingProductRequestASINList = request.ASINList;
                List<String> ASINListASINList  =  getMatchingProductRequestASINList.ASIN;
                int ASINListASINListIndex = 1;
                foreach  (String ASINListASIN in ASINListASINList)
                {
                    parameters.Add("ASINList" + "." + "ASIN" + "."  + ASINListASINListIndex, ASINListASIN);
                    ASINListASINListIndex++;
                }
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetLowestOfferListingsForASINRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetLowestOfferListingsForASIN(GetLowestOfferListingsForASINRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetLowestOfferListingsForASIN");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetASINList())
            {
                ASINListType  getLowestOfferListingsForASINRequestASINList = request.ASINList;
                List<String> ASINListASINList  =  getLowestOfferListingsForASINRequestASINList.ASIN;
                int ASINListASINListIndex = 1;
                foreach  (String ASINListASIN in ASINListASINList)
                {
                    parameters.Add("ASINList" + "." + "ASIN" + "."  + ASINListASINListIndex, ASINListASIN);
                    ASINListASINListIndex++;
                }
            }
            if (request.IsSetItemCondition())
            {
                parameters.Add("ItemCondition", request.ItemCondition);
            }
            if (request.IsSetExcludeMe())
            {
                parameters.Add("ExcludeMe", request.ExcludeMe + "");
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetServiceStatusRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetServiceStatus(GetServiceStatusRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetServiceStatus");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetMatchingProductForIdRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetMatchingProductForId(GetMatchingProductForIdRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetMatchingProductForId");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetIdType())
            {
                parameters.Add("IdType", request.IdType);
            }
            if (request.IsSetIdList())
            {
                IdListType  getMatchingProductForIdRequestIdList = request.IdList;
                List<String> idListIdList  =  getMatchingProductForIdRequestIdList.Id;
                int idListIdListIndex = 1;
                foreach  (String idListId in idListIdList)
                {
                    parameters.Add("IdList" + "." + "Id" + "."  + idListIdListIndex, idListId);
                    idListIdListIndex++;
                }
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetMyPriceForSKURequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetMyPriceForSKU(GetMyPriceForSKURequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetMyPriceForSKU");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetSellerSKUList())
            {
                SellerSKUListType  getMyPriceForSKURequestSellerSKUList = request.SellerSKUList;
                List<String> sellerSKUListSellerSKUList  =  getMyPriceForSKURequestSellerSKUList.SellerSKU;
                int sellerSKUListSellerSKUListIndex = 1;
                foreach  (String sellerSKUListSellerSKU in sellerSKUListSellerSKUList)
                {
                    parameters.Add("SellerSKUList" + "." + "SellerSKU" + "."  + sellerSKUListSellerSKUListIndex, sellerSKUListSellerSKU);
                    sellerSKUListSellerSKUListIndex++;
                }
            }

            return parameters;
        }
        
                                                
        /**
         * Convert ListMatchingProductsRequest to name value pairs
         */
        private IDictionary<String, String> ConvertListMatchingProducts(ListMatchingProductsRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "ListMatchingProducts");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetQuery())
            {
                parameters.Add("Query", request.Query);
            }
            if (request.IsSetQueryContextId())
            {
                parameters.Add("QueryContextId", request.QueryContextId);
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetCompetitivePricingForSKURequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetCompetitivePricingForSKU(GetCompetitivePricingForSKURequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetCompetitivePricingForSKU");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetSellerSKUList())
            {
                SellerSKUListType  getCompetitivePricingForSKURequestSellerSKUList = request.SellerSKUList;
                List<String> sellerSKUListSellerSKUList  =  getCompetitivePricingForSKURequestSellerSKUList.SellerSKU;
                int sellerSKUListSellerSKUListIndex = 1;
                foreach  (String sellerSKUListSellerSKU in sellerSKUListSellerSKUList)
                {
                    parameters.Add("SellerSKUList" + "." + "SellerSKU" + "."  + sellerSKUListSellerSKUListIndex, sellerSKUListSellerSKU);
                    sellerSKUListSellerSKUListIndex++;
                }
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetCompetitivePricingForASINRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetCompetitivePricingForASIN(GetCompetitivePricingForASINRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetCompetitivePricingForASIN");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetASINList())
            {
                ASINListType  getCompetitivePricingForASINRequestASINList = request.ASINList;
                List<String> ASINListASINList  =  getCompetitivePricingForASINRequestASINList.ASIN;
                int ASINListASINListIndex = 1;
                foreach  (String ASINListASIN in ASINListASINList)
                {
                    parameters.Add("ASINList" + "." + "ASIN" + "."  + ASINListASINListIndex, ASINListASIN);
                    ASINListASINListIndex++;
                }
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetProductCategoriesForSKURequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetProductCategoriesForSKU(GetProductCategoriesForSKURequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetProductCategoriesForSKU");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetSellerSKU())
            {
                parameters.Add("SellerSKU", request.SellerSKU);
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetMyPriceForASINRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetMyPriceForASIN(GetMyPriceForASINRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetMyPriceForASIN");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetASINList())
            {
                ASINListType  getMyPriceForASINRequestASINList = request.ASINList;
                List<String> ASINListASINList  =  getMyPriceForASINRequestASINList.ASIN;
                int ASINListASINListIndex = 1;
                foreach  (String ASINListASIN in ASINListASINList)
                {
                    parameters.Add("ASINList" + "." + "ASIN" + "."  + ASINListASINListIndex, ASINListASIN);
                    ASINListASINListIndex++;
                }
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetLowestOfferListingsForSKURequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetLowestOfferListingsForSKU(GetLowestOfferListingsForSKURequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetLowestOfferListingsForSKU");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetSellerSKUList())
            {
                SellerSKUListType  getLowestOfferListingsForSKURequestSellerSKUList = request.SellerSKUList;
                List<String> sellerSKUListSellerSKUList  =  getLowestOfferListingsForSKURequestSellerSKUList.SellerSKU;
                int sellerSKUListSellerSKUListIndex = 1;
                foreach  (String sellerSKUListSellerSKU in sellerSKUListSellerSKUList)
                {
                    parameters.Add("SellerSKUList" + "." + "SellerSKU" + "."  + sellerSKUListSellerSKUListIndex, sellerSKUListSellerSKU);
                    sellerSKUListSellerSKUListIndex++;
                }
            }
            if (request.IsSetItemCondition())
            {
                parameters.Add("ItemCondition", request.ItemCondition);
            }
            if (request.IsSetExcludeMe())
            {
                parameters.Add("ExcludeMe", request.ExcludeMe + "");
            }

            return parameters;
        }
        
                                                
        /**
         * Convert GetProductCategoriesForASINRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetProductCategoriesForASIN(GetProductCategoriesForASINRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetProductCategoriesForASIN");
            if (request.IsSetSellerId())
            {
                parameters.Add("SellerId", request.SellerId);
            }
            if (request.IsSetMarketplaceId())
            {
                parameters.Add("MarketplaceId", request.MarketplaceId);
            }
            if (request.IsSetASIN())
            {
                parameters.Add("ASIN", request.ASIN);
            }

            return parameters;
        }
        
                                                                                                                                                                                                                                                                

    }
}
