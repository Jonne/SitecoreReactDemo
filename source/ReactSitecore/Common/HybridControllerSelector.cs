using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.SessionState;

namespace ReactSitecore.Common
{
    /// <summary>
    /// This hybrid web api controller selector makes sure we can use site core with web api attribute routing.
    /// </summary>
    public class HybridControllerSelector : DefaultHttpControllerSelector
    {
        private readonly IHttpControllerSelector sitecoreControllerSelector;

        public HybridControllerSelector(IHttpControllerSelector sitecoreControllerSelector, HttpConfiguration config)
            : base(config)
        {
            this.sitecoreControllerSelector = sitecoreControllerSelector;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            // First check if our custom routing results in a controller.
            var descriptor = base.SelectController(request);

            if (descriptor != null)
            {
                return descriptor;
            }

            // If not, hand of to Sitecore controller selector;
            return sitecoreControllerSelector.SelectController(request);
        }
    }
}