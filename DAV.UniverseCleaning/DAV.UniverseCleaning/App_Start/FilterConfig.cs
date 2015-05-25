using System.Web;
using System.Web.Mvc;

namespace DAV.UniverseCleaning
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
