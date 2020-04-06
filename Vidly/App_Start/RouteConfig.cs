using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
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

            // Custum route for Customers

            routes.MapRoute("CustomerById", "Customer/Customers/Details/{id}", new {controller = "Customer", action = "CustomerById"});

            // Custum route for Movies

            routes.MapRoute("MovieById", "Movie/Movies/Details/{id}", new { controller = "Movie", action = "MovieById" });


        }
    }
}
