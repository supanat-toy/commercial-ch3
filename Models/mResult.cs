using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mResult
    {
        public mResult()
        {
            isSuccess = false;
            message = "N/A";
        }
        public bool isSuccess { get; set; }
        public string message { get; set; }
    }
}