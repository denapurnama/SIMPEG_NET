using System.Web;
using System.Web.Mvc;

namespace SISTEM_KEPEGAWAIAN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
