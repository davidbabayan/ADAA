using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            return View();
        }

        public ActionResult TurnLang(string lang)
        {
            var req = Request.UrlReferrer;
            string link = Request.Url.Scheme + "://" + Request.Url.Authority;
            if (req != null)
            {
                if (req.Segments.Length > 1)
                    for (int i = 0; i < req.Segments.Length; i++)
                    {
                        if (i == 1) link += lang + "/";
                        else link += req.Segments[i];
                    }
                else
                    link += "/" + lang;
            }
            else
            {
                link += "/" + lang;
            }
            return Redirect(link);
        }
    }
}