using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eSchool_Management_System
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "logins",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "logins", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
