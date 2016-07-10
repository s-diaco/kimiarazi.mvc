using KimiaRazi.Models;
using System.Web;
using System.Web.Mvc;

namespace KimiaRazi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LocalizationAttribute("fa"), 0);
        }
    }
}
