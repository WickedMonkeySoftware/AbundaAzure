using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using api.Models;
using System.ServiceModel.Channels;

namespace api.Filters
{
    public class TokenValidationAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Gets the ip of the requester
        /// </summary>
        /// <param name="actionContext">The context to execute in</param>
        /// <returns>The ip address</returns>
        private string getIP(HttpActionContext actionContext)
        {
            string ip = "";

            if (actionContext.Request.Properties.ContainsKey("MS_HttpContext"))
            {
                var context = actionContext.Request.Properties["MS_HttpContext"] as System.Web.HttpContextWrapper;
                ip = context.Request.UserHostAddress;
            }
            else if (actionContext.Request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
            {
                RemoteEndpointMessageProperty prop;
                prop = (RemoteEndpointMessageProperty)actionContext.Request.Properties[RemoteEndpointMessageProperty.Name];
                ip = prop.Address;
            }

            return ip;
        }

        /// <summary>
        /// Perform the filter
        /// </summary>
        /// <param name="actionContext">The context to perform on</param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string ip = getIP(actionContext);
            ValidateToken(actionContext, ip);
        }

        /// <summary>
        /// Validates a validation token
        /// </summary>
        /// <param name="actionContext">The context to execute</param>
        /// <param name="ip">The ip address to verify against</param>
        private void ValidateToken(HttpActionContext actionContext, string ip)
        {
            string token;

            try
            {
                token = actionContext.Request.Headers.GetValues("Authorization-Token").First();
            }
            catch (Exception)
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest) { Content = new StringContent(@"{""error"": ""Missing Authorization-Token""}") };
                return;
            }

            try
            {
                bool allowed = false;

                using (var context = new DataBaseDataContext())
                {
                    allowed = (from ev in context.KeyRestrictions
                               where ev.ApiKey.key == RSAClass.Decrypt(token) && ev.Allowed == true && (ev.IPAddress == ip || ev.IPAddress == "*")
                               select ev).Count() > 0;
                }

                if (!allowed)
                {
                    actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden) { Content = new StringContent(@"{""error"": ""Unauthorized IP Address""}") };
                }

                base.OnActionExecuting(actionContext);
            }
            catch (Exception)
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden) { Content = new StringContent(@"{""error"": ""Unauthorized User""}") };
                return;
            }
        }
    }
}