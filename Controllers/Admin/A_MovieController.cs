using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Controllers
{
    public class A_MovieController : Controller
    {
        public A_MovieController()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long platformDistributingMovieID { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
    }
}