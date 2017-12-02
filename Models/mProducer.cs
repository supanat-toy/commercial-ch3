using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mProducer
    {
        public mProducer()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long producerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string createdDatetime { get; set; }
        public string updatedDatetime { get; set; }
        public bool isDeleted { get; set; }
        public string imageURL { get; set; }
    }
}