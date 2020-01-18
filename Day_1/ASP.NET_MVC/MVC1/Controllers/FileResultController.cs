using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class FileResultController : Controller
    {
        // GET: FileResult
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"d:\lighthouse.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"d:\lighthouse.jpg", "image/jpg", "default.jpg");
        }


       
    }
}