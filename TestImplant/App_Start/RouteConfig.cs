﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestImplant
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                "Allo",
                "{order}",
                new { controller = "Test", action = "Index", order = "dystopia" }
            );*/

            routes.MapRoute(
                "Contact",
                "",
                new { controller = "Contact", action = "ContactForm" }
            );

            
        }
    }
}