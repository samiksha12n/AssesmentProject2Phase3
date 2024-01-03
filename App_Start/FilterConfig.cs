using System.Web;
using System.Web.Mvc;

namespace AssesmentPhase2E_CommercePortal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
