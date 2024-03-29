﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SportsStore.WebUI.Infrastructure;
using SportsStore.Domain.Concrete;
using System.Data.Entity;
using SportsStore.WebUI.Binders;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
                 "",
                 new { Controller = "Product", action = "List",
                       category = (string)null, page = 1}
                 );

            routes.MapRoute(null,
                "Page{page}",
                new { Controller = "Product", action = "List", category = (string)null },
                new { page = @"\d+" }
                );

            routes.MapRoute(null,
                "{category}",
                new { controller = "Product", action = "List", page = 1 }
                );

            routes.MapRoute(null,
                "{category}/Page{page}", // Route name
                new { controller = "Product", action = "List", id = UrlParameter.Optional }, // Parameter defaults
                new { page = @"\d+" }
            );

            routes.MapRoute(null, "{controller}/{action}");

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            Database.SetInitializer(new SportsStoreInitializer());

            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}