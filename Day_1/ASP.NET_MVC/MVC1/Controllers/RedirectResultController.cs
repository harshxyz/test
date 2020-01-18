using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class RedirectResultController : Controller
    {
        // GET: RedirectResult
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }
    }
}