using System.Web;
using System.Web.Mvc;

namespace skeletonRESTApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        internal static void RegisterHttpFilters(System.Web.Http.Filters.HttpFilterCollection httpFilterCollection)
        {
          //  httpFilterCollection.Add(new LogControllerActionFilter()); 
        }
    }
}
