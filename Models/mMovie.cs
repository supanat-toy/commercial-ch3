using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace commercial_ch3.Models
{
    public class mMovie
    {
        public mMovie()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        public long movieID { get; set; }
        public int boardClassYear { get; set; }
        public string channel { get; set; }
        public double rating { get; set; }
        public List<mGenre> genreList { get; set; }
        public string description { get; set; }
        public mProducer producer { get; set; }
        public mDirector director { get; set; }
        public List<mCelebrity> celebrityList { get; set; }
        public int episodeNumber { get; set; }
        public string totalTime { get; set; }
        public string trailerVideoURL { get; set; }
        public string posterImageURL { get; set; }
        public string isDeleted { get; set; }
        public string isRequestedDelete { get; set; }
        public string createdDateTime { get; set; }
        public string updatedDateTime { get; set; }
        public List<string> imageURLList { get; set; }
    }
}