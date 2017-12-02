using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mCountry
    {
        public mCountry()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long countryID { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
    }
}