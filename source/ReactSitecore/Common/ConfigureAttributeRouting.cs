using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;

using Sitecore.Pipelines;

namespace ReactSitecore.Common
{
    public class ConfigureAttributeRouting
    {
        public void Process(PipelineArgs args)
        {
            // Map Attribute Routes
            GlobalConfiguration.Configure(config => config.MapHttpAttributeRoutes());

            // Replace IHttpControllerSelector with our custom implementation
            GlobalConfiguration.Configure(ReplaceSitecoreControllerSelector);
        }

        /// <summary>
        ///     Replaces the default sitecore controller selector with our hybrid controller. This is needed
        ///     to enable web api attribute routing with Sitecore.
        /// </summary>
        private static void ReplaceSitecoreControllerSelector(HttpConfiguration config)
        {
            var sitecoreControllerSelector = config.Services.GetHttpControllerSelector();

            //add tracking based on attribute.
            var newConfig = new HttpConfiguration(new HttpRouteCollection());
            newConfig.MapHttpAttributeRoutes();

            var hybridControllerSelector = new HybridControllerSelector(sitecoreControllerSelector, newConfig);

            config.Services.Replace(typeof(IHttpControllerSelector), hybridControllerSelector);
        }
    }
}