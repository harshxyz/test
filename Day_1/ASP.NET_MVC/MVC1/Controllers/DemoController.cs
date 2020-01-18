using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public string Hello(int? id)
        {
            //return "hello world" + id;
            if (!id.HasValue) {
                return "return parameter is null";
            }
            return "return parameter is "+id;
        }
    }
}