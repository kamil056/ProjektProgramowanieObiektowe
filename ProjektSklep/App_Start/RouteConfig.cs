using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjektSklep
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "KursyList",
                url: "kategoria/{nazwakategori}",
                defaults: new { Controller = "Produkty", Action = "Lista" }
            );
            routes.MapRoute(
                name: "StaticPage",
                url: "staticPage/{page}.html",
                defaults: new {Controller = "Home", Action = "StaticPage"}
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
