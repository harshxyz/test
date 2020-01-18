using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class ActionResultController : Controller
    {
        // GET: ActionResult
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of ContentResult</h1>");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/xml");
            }
            else
                return Content("Invalid content type");
        }
    }
}
