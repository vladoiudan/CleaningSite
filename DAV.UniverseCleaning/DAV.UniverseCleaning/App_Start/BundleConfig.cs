using System.Web;
using System.Web.Optimization;

namespace DAV.UniverseCleaning
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/modernizr-*",
                      "~/Scripts/jquery.excoloSlider.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/jquery.excoloSlider.css",
                      "~/Content/bootstrap.css",
                      "~/Content/menu.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/slick").Include(
                     "~/Content/slick.css",
                     "~/Content/slick-theme.css"));
        }
    }
}
