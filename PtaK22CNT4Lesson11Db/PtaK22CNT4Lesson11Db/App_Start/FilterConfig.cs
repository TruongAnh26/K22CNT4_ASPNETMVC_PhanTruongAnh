using System.Web;
using System.Web.Mvc;

namespace PtaK22CNT4Lesson11Db
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
