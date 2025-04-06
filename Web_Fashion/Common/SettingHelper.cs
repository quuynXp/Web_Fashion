using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Fashion.Models;

namespace Web_Fashion.Common
{
    public class SettingHelper
    {
        private static Fashion_ShopDbContext db = new Fashion_ShopDbContext();

        public static string GetValue(string key)
        {
            var item = db.SystemSettings.SingleOrDefault(x => x.SettingKey == key);
            if (item != null)
            {
                return item.SettingValue;
            }
            return "";
        }
    }
}