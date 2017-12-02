using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mOrderMoviePublicRights
    {
        public mOrderMoviePublicRights()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long orderMoviePublicRightsID { get; set; }
        public mCountry country { get; set; }
        public long orderMovieID { get; set; }
    }
}
