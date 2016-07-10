using System.Web;
using System.Web.Optimization;

namespace KimiaRazi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/agency.css",
                      "~/Content/kimiarazi.css",
                      "~/Content/animate.css"));

            bundles.Add(new StyleBundle("~/Content/css-rtl").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/agency.css",
                      "~/Content/kimiarazi.css",
                      "~/Content/animate.css",
                      "~/Content/kimiarazi-rtl.css"));

            bundles.Add(new StyleBundle("~/Content/css-home").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/grayscale.css",
                      "~/Content/stylish-portfolio.css",
                      "~/Content/kimiarazi.css",
                      "~/Content/animate.css"));

            bundles.Add(new StyleBundle("~/Content/css-home-rtl").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/grayscale.css",
                      "~/Content/stylish-portfolio.css",
                      "~/Content/kimiarazi.css",
                      "~/Content/animate.css",
                      "~/Content/kimiarazi-rtl.css"));

            bundles.Add(new ScriptBundle("~/bundles/shared-scripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/jquery.easing.min.js",
                        "~/Scripts/jquery.viewportchecker.min.js"));

            // BundleTable.EnableOptimizations = true;
            // bundles.UseCdn = true;
        }
    }
}
