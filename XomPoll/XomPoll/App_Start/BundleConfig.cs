using System.Web;
using System.Web.Optimization;

namespace XomPoll
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/materialize",
                      "~/Content/materialize/css/materialize.css"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                      "~/Scripts/materialize/materialize.js",
                      "~/Scripts/angular-materialize.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-sanitize.js",
                      "~/Scripts/angular-animate.js",
                      "~/Scripts/angular-touch.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/App/App.js"));
        }
    }
}
