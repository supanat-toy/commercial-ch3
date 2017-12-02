using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mCustomer
    {
        public mCustomer()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string customerType { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string country { get; set; }
        public string phoneNumber { get; set; }
        public string createdDatetime { get; set; }
        public string updatedDatetime { get; set; }
        public bool isDeleted { get; set; }
        public bool isRequestedDeleted { get; set; }
        public string imageURL { get; set; }
    }
}
