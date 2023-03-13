using System.Web;
using System.Web.Mvc;

namespace Buoi3_2011060858_VoDuyPhuoc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
