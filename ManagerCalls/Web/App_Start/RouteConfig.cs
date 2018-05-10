﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "",
                url: "{controller}/{action}/{id1}/{id2}",
                defaults: new { controller = "User", action = "Index", id1 = UrlParameter.Optional, id2 = UrlParameter.Optional }
            );
        }
    }
}
