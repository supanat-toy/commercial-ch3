using System;
using System.IO;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using commercial_ch3.Models;

namespace commercial_ch3.Functions
{
    public class Image : FunctionsHelper
    {
        public List<string> SaveImageFile(List<HttpPostedFileBase> product_Image_List, string pathFolder)
        {
            var p = Path.Combine("/Images", pathFolder);
            return Save(product_Image_List, p);
        }
        public List<string> Save(List<HttpPostedFileBase> imageList, string path) //IDictionary<Guid, string>
        {
            if (imageList.Count <= 0)
            {
                return null;
            }

            //// If no dir exists, create one !
            if (!Directory.Exists(HttpContext.Current.Server.MapPath(path)))
            {
                Directory.CreateDirectory(HttpContext.Current.Server.MapPath(path));
            }

            Dictionary<Guid, string> fileList = new Dictionary<Guid, string>();
            List<string> filePathUrlList = new List<string>();
            foreach (var file in imageList)
            {
                Guid guid = Guid.NewGuid();
                var filePath = Path.Combine(HttpContext.Current.Server.MapPath(path), guid + Path.GetExtension(file.FileName));
                var filePathUrl = Path.Combine(path, guid + Path.GetExtension(file.FileName));
                //fileList.Add(guid, VirtualPathUtility.ToAbsolute(filePathUrl));
                filePathUrlList.Add(VirtualPathUtility.ToAbsolute(filePathUrl));
                try
                {
                    file.SaveAs(filePath);
                    //SaveToDatabase(filePathUrl);
                }
                catch(Exception e) {
                    Console.WriteLine(e);
                    int a = 0;
                }
            }


            return filePathUrlList;
        }
    }
}