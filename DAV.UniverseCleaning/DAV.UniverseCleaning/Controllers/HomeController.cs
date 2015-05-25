using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAV.UniverseCleaning.Helpers;
using DAV.UniverseCleaning.Models;

namespace DAV.UniverseCleaning.Controllers
{
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
        public ActionResult Contact(ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                IMailServiceBll mailService = new SmtpMailServiceBll();
                var email = "vladoiudan@yahoo.com";
                mailService.SendMail(message.Email, string.Format("Contact Form Submission: {0}", message.Name),
                    message.Message, false, email);
                ViewBag.SuccessMessage = "We have received your message and it will be processed soon. Thank you.";
            }
            return View(message);
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