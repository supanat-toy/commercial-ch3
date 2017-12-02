using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mGenre
    {
        public mGenre()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public bool genreID { get; set; }
        public string name { get; set; }
    }
}