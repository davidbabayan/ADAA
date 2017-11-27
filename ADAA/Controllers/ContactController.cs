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
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SomeAction()
        {
            return PartialView();
        }
    }
}