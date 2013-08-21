using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    public class AuthorizedIP
    {
        public static IQueryable<string> AuthorizedIps
        {
            get
            {
                var ips = new List<string>();
                ips.Add("127.0.0.1");
                ips.Add("::1");

                return ips.AsQueryable();
            }
        }
    }
}