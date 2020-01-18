using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HomeHtmlController : Controller
    {
        // GET: HomeHtml
        public ActionResult HtmlHelper()
        {
            return View();
        }
    }
}