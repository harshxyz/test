using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    [RoutePrefix("DEMOROUTE")]
    public class RouteDemoController : Controller
    {
        
        //// GET: RouteDemo
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [Route]
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        [Route("getinfo")]
        public string GetDetails()
        {
            return "Hello World1";
        }
        [Route("Display")]
        public ActionResult GetDetails1()
        {
            return Content("Hello World2");
        }
        [Route("Display1")]
        public ActionResult GetDetails3()
        {
            return Content("Hello World3");
        }


        [Route("cal/{quantity}/{price}")]
        public ActionResult Price(int quantity, float price)
        {
            float result = quantity * price;
            return Content("<script>alert('Total Price is" + result + "');</script>");

        }

        [Route("Print/{name?}")]
        public ActionResult PrintName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return Content("<h2> Your Name is " + name + "</h2>");
            }
            return Content("<h2><font color='red'>" + "Please Enter Name</font></h2>");
        }

        [Route("Display/{age:int:max(100)}")]
        // [Route("Display/{age:int:regex([1-9]{2})}")]
        public ActionResult PrintAge(int age)
        {
            return Content("Your Age is " + age);
        }
    }
}