using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            Models.Product p = new Models.Product();
            //pass a list of products to the view return 
            return View(p.GetProducts());
            //return View();
        }
        public ActionResult MagicView()
        {
            Models.Product p = new Models.Product();
            //pass a list of products to the view return 
            return View(p.GetProducts());
            //return View();
        }
    }
}