using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            //< script src = "/PD/ContentLocal/jquery-3.1.1.min.js" ></ script >
            //< script src = "/PD/ContentLocal/jquery-ui-1.12.1.min.js" ></ script >
            //< script src = "/PD/Content/js/perfect-scrollbar.jquery.min.js" ></ script >
            //< script src = "/PD/ContentLocal/angular.min.js" ></ script >
            //< script src = "/PD/ContentLocal/angular-animate.min.js" ></ script >
            //< script src = "/PD/Content/js/bootstrap.js" ></ script >
            //< script src = "/PD/ContentLocal/ui-bootstrap-tpls-2.5.0.min.js" ></ script >


            bundles.Add(new ScriptBundle("~/bundles/angularFile").Include(
               "~/Scripts/angular.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
