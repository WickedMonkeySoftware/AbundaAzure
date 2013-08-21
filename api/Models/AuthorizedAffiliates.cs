using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    public class AuthorizedAffiliates
    {
        public static IEnumerable<ApiKey> Keys
        {
            get
            {
                IList<ApiKey> ret = new List<ApiKey>();

                ApiKey key = new ApiKey();
                key.key = "abundatrade";

                ret.Add(key);
                return ret;
            }
        }
    }
}