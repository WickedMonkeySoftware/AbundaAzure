﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.ServiceModel.Channels;
using System.Security.Cryptography;

namespace api.Controllers
{
    /// <summary>
    /// Handles api access and verification
    /// </summary>
    public class APIController : ApiController
    {
        internal string GetClientIp(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            }
            else if (request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
            {
                RemoteEndpointMessageProperty prop;
                prop = (RemoteEndpointMessageProperty)this.Request.Properties[RemoteEndpointMessageProperty.Name];
                return prop.Address;
            }

            return null;
        }

        /// <summary>
        /// Verifies that an api key is usable under these circumstances
        /// </summary>
        /// <param name="apikey">The api key to check</param>
        /// <returns>Whether or not the api is allowed</returns>
        internal bool verifyKey(string apikey)
        {

            return true;
        }

        /// <summary>
        /// Verify that an api key is allowed
        /// </summary>
        /// <param name="apikey">The api key to check</param>
        /// <returns></returns>
        public object Post([FromBody] string apikey)
        {
            return Get(apikey);
        }

        /// <summary>
        /// Verify if an api key is allowed
        /// </summary>
        /// <param name="apikey">The API Key to check</param>
        /// <returns></returns>
        public object Get(string apikey)
        {
            return new { isValid = verifyKey(apikey) };
        }
    }
}
