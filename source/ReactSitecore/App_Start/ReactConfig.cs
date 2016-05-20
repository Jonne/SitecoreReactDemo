using React;

using ReactSitecore;

using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(ReactConfig), "Configure")]

namespace ReactSitecore
{
    public static class ReactConfig
    {
        public static void Configure()
        {
            ReactSiteConfiguration.Configuration
				.AddScript("~/Scripts/Components/Cart.jsx")
				.AddScript("~/Scripts/Components/CartLine.jsx");
        }
    }
}
