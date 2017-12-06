using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ADAA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }

    public class InternationalizationAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if(LangInfo.Language == "" || LangInfo.Language == null)
            {
                LangInfo.Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            }

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(LangInfo.Language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(LangInfo.Language);
        }
    }

    public static class LangInfo
    {
        public static string Language { get; set; }
    }
}
