using System.Web.Mvc;
using System.Web.Routing;

namespace People
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "PersonLookup",
                url: "PeopleLookup/{idNumber}",
                defaults: new { controller = "PeopleLookup", action = "Get" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "People", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}