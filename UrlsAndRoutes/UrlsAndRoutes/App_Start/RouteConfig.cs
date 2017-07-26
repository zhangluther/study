using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
       public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("MyRoute","{controller}/{action}/{id}",new { controller = "Home", action = "Index", id = UrlParameter.Optional});
            routes.MapRoute("YourRoute", "public/{controller}/{action}", new { controller = "Home", action = "Index"});
            routes.MapRoute("", "X{controller}/{action}/{id1}/{id2}", new { controller = "Home", action = "Index", id1 = UrlParameter.Optional, id2 = UrlParameter.Optional });
        }
    }
}
