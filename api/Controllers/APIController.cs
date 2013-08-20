using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    /// <summary>
    /// Handles api access and verification
    /// </summary>
    public class APIController : ApiController
    {
        internal bool verifyKey(string apikey)
        {
            return true;
        }

        public object Post([FromBody] string apikey)
        {
            return new { isValid = verifyKey(apikey) };
        }

        public object Get(string apikey)
        {
            return new { isValid = verifyKey(apikey) };
        }
    }
}
