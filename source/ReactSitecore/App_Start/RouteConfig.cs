using System.Web.Mvc;
using System.Web.Routing;

using ReactSitecore.App_Start;

using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(RouteConfig), "Configure")]

namespace ReactSitecore.App_Start
{
    public class RouteConfig
    {
        public static void Configure()
        {
            RouteTable.Routes.MapMvcAttributeRoutes();
        }
    }
}
