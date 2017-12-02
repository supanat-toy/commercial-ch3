using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mOrderMovie
    {
        public mOrderMovie()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long orderMovieID { get; set; }
        public long orderID { get; set; }
        public long movieID { get; set; }
        public bool isExclusive { get; set; }
        public mPlatformDistributingMovie platformDistributingMovie { get; set; }
        public mOrderStatus orderStatus { get; set; }
        public bool isDeleted { get; set; }
        public string createdDatetime { get; set; }
        public string updatedDatetime { get; set; }

        //
        public string contractBeginDate { get; set; }
        public string contractExpireDate { get; set; }
        public double salsPrice { get; set; }
        public bool isCancelled { get; set; }
        
    }
}