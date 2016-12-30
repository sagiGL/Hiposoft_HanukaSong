﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hiposoft_HanukaSong
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DefaultPage",
                url: "",
                defaults: new { controller = "Song", action = "Enter", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "NewSong",
              url: "NewSong",
              defaults: new { controller = "Song", action = "NewSong", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Song", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
