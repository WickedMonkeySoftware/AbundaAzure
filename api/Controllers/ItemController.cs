using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    /// <summary>
    /// Performs an action on an item
    /// </summary>
    public class ItemController : ApiController
    {
        /// <summary>
        /// Executes an action
        /// </summary>
        /// <param name="action">The action to execute</param>
        /// <param name="product_code">The upc/isbn to perform the action to</param>
        /// <param name="qty">The qty to apply it</param>
        /// <returns>The answer to the question</returns>
        private object execute(string action, string product_code, int qty)
        {
            switch (action)
            {
                case "delete":
                    break;
                case "add":
                    break;
                case "modify":
                    break;
                default:
                    return error("Invalid action performed");
            }

            return "action = " + action + " - product_code: " + product_code + " (" + qty + ")";
        }

        private object error(string message)
        {
            return new { error = message };
        }

        /// <summary>
        /// Performs an action on an item
        /// </summary>
        /// <param name="apikey">The api key for the site</param>
        /// <param name="action">The action to perform</param>
        /// <param name="product_code">The item to perform the action on</param>
        /// <param name="qty">the quantity to affect</param>
        /// <returns>The result of the action</returns>
        public object Post([FromBody] string apikey, [FromBody] string action, [FromBody] string product_code, [FromBody] int qty)
        {
            return Get(apikey, action, product_code, qty);
        }

        /// <summary>
        /// Performs an action on an item
        /// </summary>
        /// <param name="apikey">The api key for the site</param>
        /// <param name="action">The action to perform</param>
        /// <param name="product_code">The item to perform the action on</param>
        /// <param name="qty">The quantity to affect</param>
        /// <returns>The result of the action</returns>
        public object Get(string apikey, string action, string product_code, int qty)
        {
            APIController api = new APIController();
            bool isVerified = api.verifyKey(apikey);

            if (isVerified)
            {
                return execute(action, product_code, qty);
            }

            return error("Invalid API Key usage");
        }
    }
}
