﻿namespace PIM.Web
{
    using PIM.Web.App_Start;
    using PIM.Web.Mappers;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
