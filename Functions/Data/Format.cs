using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using commercial_ch3.Models;

namespace commercial_ch3.Functions
{
    public class Format : FunctionsHelper
    {
        public string getFormatDate_dMyyyy(DateTime dt) // 9/3/2008
        {
            return String.Format("{0:d/M/yyyy}", dt).Replace("-","/");
        }
        public string getFormatDate_dMMMMyyyy(DateTime dt) // 9 January 2008
        {
            return string.Format("{0:d MMMM yyyy}", dt).Replace("-", "/");
        }

        public string getFormatDate_dMyyyyHHmmSS(DateTime dt)
        {
            return string.Format("{0:d/M/yyyy HH:mm:ss}", dt).Replace("-", "/");
        }

        public DateTime getDateTime_dMyyyyHHmmSS(string dt)
        {
            string[] split = dt.Split(' ');
            string[] dateSplit = split[0].Split('/');
            string[] timeSplit = split[1].Split(':');

            return new DateTime(Convert.ToInt32(dateSplit[2]), Convert.ToInt32(dateSplit[1]), Convert.ToInt32(dateSplit[0]), Convert.ToInt32(timeSplit[0]), Convert.ToInt32(timeSplit[1]), Convert.ToInt32(timeSplit[2])); //string.Format("{0:d MMMM yyyy HH:mm:ss}", dt).Replace("-", "/");
        }
    }
}