using System.Web.Mvc;
using System.Web.UI;

namespace DAV.UniverseCleaning.Controllers
{
    [OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Client)]
    public class ReadMoreController : Controller
    {
        public ActionResult CustomerSatisfaction()
        {
            return View();
        }

        public ActionResult WhyUs()
        {
            return View();
        }
    }
}