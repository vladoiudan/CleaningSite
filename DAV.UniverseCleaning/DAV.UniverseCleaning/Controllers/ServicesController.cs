using System.Web.Mvc;
using System.Web.UI;

namespace DAV.UniverseCleaning.Controllers
{
    //[OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Client)]
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DomesticCleaning()
        {
            return View();
        }

        public ActionResult OvenCleaning()
        {
            return View();
        }

        public ActionResult EndOfTenancyCleaning()
        {
            return View();
        }

        public ActionResult AfterBuildersCleaning()
        {
            return View();
        }

        public ActionResult IroningAtHome()
        {
            return View();
        }

        public ActionResult ComercialService()
        {
            return View();
        }

        public ActionResult SpringCleaning()
        {
            return View();
        }

        public ActionResult CarpetCleaning()
        {
            return View();
        }
    }
}