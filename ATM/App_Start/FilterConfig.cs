using System.Web;
using System.Web.Mvc;

namespace ATM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // can chage error view at Web.config
            //<customEooros mode="On"/>
        }
    }
}
