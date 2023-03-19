using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Proje
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_AcquireRequestState(Object o, EventArgs a)
        {
            if (HttpContext.Current.Session == null) return;
            var dil = (CultureInfo)Session["Dil"];
            if (dil == null)
            {
                var languageName = "tr";
                dil = new CultureInfo(languageName);
                Session["Culture"] = dil;
            }
            Thread.CurrentThread.CurrentUICulture = dil;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(dil.Name);
        }
    }
}
