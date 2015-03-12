using System.Web.Mvc;
using FloraLimitedTest.Filter;

namespace FloraLimitedTest {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AreaAuthorizeAttribute());
        }
    }
}