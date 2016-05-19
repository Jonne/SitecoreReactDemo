using System.Web;
using System.Web.SessionState;

using Sitecore.Pipelines;

namespace ReactSitecore.Common
{
    public class RestSessionEnabler
    {
        public virtual void Process(PipelineArgs args)
        {
            if (IsWebApiRequest())
            {
                HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
            }
        }
        
        private bool IsWebApiRequest()
        {
            return HttpContext.Current.Request.AppRelativeCurrentExecutionFilePath.StartsWith("~/api");
        }
    }
}
