using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mOrder
    {
        public mOrder()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long orderID { get; set; }
        public mCustomer customer { get; set; }
        public string orderDatetime { get; set; }
        public string updatedDatetime { get; set; }
        public double totalPrice { get; set; }
    }
}