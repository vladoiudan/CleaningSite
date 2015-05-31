using System;
using System.Web.Mvc;
using System.Web.UI;
using DAV.UniverseCleaning.Helpers;
using DAV.UniverseCleaning.Models;

namespace DAV.UniverseCleaning.Controllers
{
    //[OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Client)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new ContactMessage());
        }
        [HttpPost]
        public ActionResult Contact(ContactMessage data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    IMailService mailService = new SmtpMailService();
                    const string email = "info@universecleaning.co.uk";
                    mailService.SendMail(data.Email, string.Format("Contact Form Submission: {0}", data.Name),
                        data.Message, false, email);
                    ViewBag.SuccessMessage = "We have received your message and it will be processed soon. Thank you.";
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Error", ex);
                }
            }
            return View(data);
        }

        public ActionResult Offers()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }
    }
}