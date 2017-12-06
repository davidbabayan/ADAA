using ADAA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADAA.Controllers
{
    [Internationalization]
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Result = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
            bool res = false;
            ViewBag.Result = res ? 
                "<p class=\"bg-success text-center\">Message is sent!</p>" :
                "<p class=\"bg-warning text-center\">Error occurred!</p>";
            return View();
        }
    }
}