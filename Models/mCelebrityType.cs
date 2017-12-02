using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mCelebrityType
    {
        public mCelebrityType()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long celebrityTypeID { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
    }
}