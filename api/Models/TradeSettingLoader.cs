using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    public class TradeSettingLoader
    {


        public static void LoadForAffiliate(int aff, string key, out string value)
        {
            using (var context = new DataBaseDataContext())
            {
                var settings = (from ev in context.AffiliateSettings
                                where ev.affiliate_id == aff && ev.TradeSetting.key == key
                                select ev).FirstOrDefault();

                value = settings.value;
            }
        }

        public static void LoadForAffiliate(int aff, string key, out int value)
        {
            string test;

            LoadForAffiliate(aff, key, out test);

            value = int.Parse(test);
        }

        public static void LoadForAffiliate(int aff, string key, out decimal value)
        {
            string test;

            LoadForAffiliate(aff, key, out test);

            value = decimal.Parse(test);
        }

        public static void LoadForAffiliate(int aff, string key, out TriBool value)
        {
            string test;

            LoadForAffiliate(aff, key, out test);

            bool result;

            var t = bool.TryParse(test, out result);

            if (t)
            {
                if (result)
                {
                    value = TriBool.True;
                }
                else
                {
                    value = TriBool.False;
                }
            }
            else
            {
                value = TriBool.Unknown;
            }
        }

        public static void CreateDefaultSettings(int aff)
        {
            using (var context = new DataBaseDataContext())
            {
                var def = from ev in context.TradeSettings
                          select ev;

                foreach (var setting in def)
                {
                    var set = new AffiliateSetting();
                    set.affiliate_id = aff;
                    set.settings_id = setting.ID;
                    set.value = setting.@default;

                    context.AffiliateSettings.InsertOnSubmit(set);
                }

                context.SubmitChanges();
            }
        }
    }
}