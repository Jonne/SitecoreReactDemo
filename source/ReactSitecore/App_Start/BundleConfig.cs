using System.Web.Optimization;
using System.Web.Optimization.React;

using ReactSitecore;

using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(BundleConfig), "Configure")]

namespace ReactSitecore
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void Configure()
        {
            var bundles = BundleTable.Bundles;

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-2.2.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/react")
                .Include("~/Scripts/react.js")
                .Include("~/Scripts/react-dom.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/Site.css"));

            bundles.Add(new BabelBundle("~/bundles/main").Include(
                "~/Scripts/Components/Cart.jsx",
                "~/Scripts/Components/CartLine.jsx"
                ));
        }
    }
}
