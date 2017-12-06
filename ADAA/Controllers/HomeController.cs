using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace ADAA.Controllers
{
    [Internationalization]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var tr = Thread.CurrentThread;
            return View();
        }

        public ActionResult TurnLang(string lang)
        {
            if (lang == "en" || lang == "hy")
            {
                LangInfo.Language = lang;
            }
            else
            {
                LangInfo.Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            }
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}