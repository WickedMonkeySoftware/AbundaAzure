using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api
{
    public class Util
    {
        public static decimal RoundUpToNearest(decimal number, decimal roundTo)
        {
            if (roundTo == 0)
            {
                return number;
            }
            else
            {
                return Math.Ceiling(number / roundTo) * roundTo;
            }
        }

        public static decimal RoundDownToNearest(decimal number, decimal roundTo)
        {
            if (roundTo == 0)
            {
                return number;
            }
            else
            {
                return Math.Floor(number / roundTo) * roundTo;
            }
        }
    }
}