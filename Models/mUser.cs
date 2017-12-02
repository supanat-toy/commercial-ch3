using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mUser
    {
        public mUser()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string createdDatetime { get; set; }
        public string updatedDatetime { get; set; }
        public bool isDeleted { get; set; }
        public bool isAdmin { get; set; }
        public string ImageURL { get; set; }
    }
}