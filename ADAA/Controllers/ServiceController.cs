﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADAA.Controllers
{
    [Internationalization]
    public class ServiceController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}