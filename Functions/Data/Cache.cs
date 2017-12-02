using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using commercial_ch3.Models;

namespace commercial_ch3.Functions
{
    public class Cache : FunctionsHelper
    {
        public static object getCacheData(string key)
        {
            
            return Microsoft.AspNetCore.Http.HttpContext.Cache[key];
        }

        public static void setCacheData(string key, object value, double minute)
        {
            HttpContext.Current.Cache.Insert(key, value, null, DateTime.Now.AddMinutes(minute), TimeSpan.Zero, CacheItemPriority.Default, null);
        }
    }
}