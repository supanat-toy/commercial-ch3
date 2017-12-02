using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mCelebrityContract
    {
        public mCelebrityContract()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long celebrityContractID { get; set; }
        public string beginningDate { get; set; }
        public string expiringDate { get; set; }
        public bool isCancelled { get; set; }
        public bool isDeleted { get; set; }
    }
}