using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMVCTesting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "MyAPI",
                url: "Products/Details/{id}",
                defaults: new { controller = "Home", action = "DetailProduct" }
            );

            routes.MapRoute(
                name: "MyAPIOrder",
                url: "Order/OrderDetail",
                defaults: new { controller = "Home", action = "DetailOrder" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
