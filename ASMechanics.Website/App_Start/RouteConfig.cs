using System.Web.Routing;
using System.Web.Mvc;

namespace ASMechanics.Website.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                null,
                "MainMenu/MainMenu",
                new { controller = "MainMenu", action = "MainMenu" }
            );
        }
    }
}