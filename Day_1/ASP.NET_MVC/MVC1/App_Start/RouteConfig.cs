using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

       //     routes.MapRoute(
       //         name: "Default1",
       //         url: "{controller}/{action}/{id}",
       //         defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
       //     );

       //     routes.MapRoute(
       //        name: "Default2",
       //        url: "{controller}/{action}/{id}",
       //        defaults: new { controller = "Demo", action = "Index", id = UrlParameter.Optional }
       //    );

       //     routes.MapRoute(
       //        name: "Default3",
       //        url: "{controller}/{action}/{id}",
       //        defaults: new { controller = "ActionResult", action = "Index", id = UrlParameter.Optional }
       //    );

       //     routes.MapRoute(
       //        name: "Default4",
       //        url: "{controller}/{action}/{id}",
       //        defaults: new { controller = "FileResult", action = "Index", id = UrlParameter.Optional }
       //    );

       //     routes.MapRoute(
       //        name: "Default5",
       //        url: "{controller}/{action}/{id}",
       //        defaults: new { controller = "RedirectResult", action = "Index", id = UrlParameter.Optional }
       //    );

       //     routes.MapRoute(
       //       name: "Default6",
       //       url: "{controller}/{action}/{id}",
       //       defaults: new { controller = "Razor", action = "Index", id = UrlParameter.Optional }
       //   );

       //     routes.MapRoute(
       //     name: "Default7",
       //     url: "{controller}/{action}/{id}",
       //     defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional }
       //  );

       //     routes.MapRoute(
       //    name: "Default8",
       //    url: "{controller}/{action}/{id}",
       //    defaults: new { controller = "ViewData", action = "viewdatabagdemo", id = UrlParameter.Optional }
       // );
       //     routes.MapRoute(
       //   name: "Default9",
       //   url: "{controller}/{action}/{id}",
       //   defaults: new { controller = "Home", action = "AddUser", id = UrlParameter.Optional }
       //);
       //     routes.MapRoute(
       //   name: "Default10",
       //   url: "{controller}/{action}/{id}",
       //   defaults: new { controller = "HomeHtml", action = "HtmlHelper", id = UrlParameter.Optional }
       //);


        }
    }
}
