using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net.Http;
using System.ServiceModel.Channels;
using api.Models;

namespace api.Filters
{
    public class IPHostValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
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

            try
            {
                AuthorizedIP.AuthorizedIps.First(x => x == ip);
            }
            catch (Exception)
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden) { Content = new StringContent("Unauthorized IP Address") };
                return;
            }
        }
    }
}