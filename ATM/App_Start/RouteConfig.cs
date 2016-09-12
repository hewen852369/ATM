using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ATM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // crating custom url route for serial number look up
            routes.MapRoute(
                name: "Serial number",
                url: "serial/{letterCase}",
                defaults: new { controller = "Home", action = "Serial", letterCase="upper" }
            );
            // define route setting
            routes.MapRoute(
                // give route a name
                name: "Default",
                // url format for route
                url: "{controller}/{action}/{id}",
                // give defaults if controller and action is not specific according to the url format
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
