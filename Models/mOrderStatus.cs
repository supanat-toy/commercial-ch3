using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mOrderStatus
    {
        public mOrderStatus()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long orderStatusID { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
    }
}
