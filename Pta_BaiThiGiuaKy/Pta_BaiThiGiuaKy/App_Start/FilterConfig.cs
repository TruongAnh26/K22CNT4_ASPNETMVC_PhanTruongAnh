using System.Web;
using System.Web.Mvc;

namespace Pta_BaiThiGiuaKy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
