using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mCelebrity
    {
        public mCelebrity()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long celebrityID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public string birthday { get; set; }
        public string nationality { get; set; }
        public string religion { get; set; }
        public List<mCelebrityContract> contractCelebrityList { get; set; }
        public string IG { get; set; }
        public string createdDatetime { get; set; }
        public string updatedDatetime { get; set; }
        public bool isDeleted { get; set; }
        public bool isRequestedDelete { get; set; }
        public string celebrityType { get; set; }
        public List<string> languageList { get; set; }
        public List<string> sportList { get; set; }
        public List<string> hobbieList { get; set; }
        public List<string> imageURLList { get; set; }
    }
}