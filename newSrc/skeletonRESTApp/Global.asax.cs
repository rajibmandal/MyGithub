using BusinessMgr;
using EagleView.SCSMRESTService.App_Start;
using skeletonRESTApp.App_Start;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace skeletonRESTApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //private static readonly log4net.ILog log =
        //    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void Application_Start()
        {
            Trace.Listeners.Add(new Log4netTraceListener());
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            FilterConfig.RegisterHttpFilters(GlobalConfiguration.Configuration.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Trace.WriteLine("Application Statred");
            string db = StringHelper.DBPath;
            System.Web.HttpContext.Current.Application["Core"] = BusinessMgrPlugin.GetBusinessMgr(db);

        }
    }
}
