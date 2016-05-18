using System.Web;
using System.Web.SessionState;

using Sitecore.Pipelines;

namespace ReactSitecore.Common
{
    public class RestSessionEnabler
    {
        public virtual void Process(PipelineArgs args)
        {
            HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
        }
    }
}
