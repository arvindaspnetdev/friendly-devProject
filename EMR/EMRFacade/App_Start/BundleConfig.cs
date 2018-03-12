using System.Web;
using System.Web.Optimization;

namespace EMRFacade
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Scripts/jquery-{version}.js"
                        "~/assets/lib/jquery/jquery.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      //"~/Scripts/bootstrap.js",
                      //"~/Scripts/respond.js"
                      "~/assets/lib/bootstrap/dist/js/bootstrap.bundle.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/perfect-scrollbar").Include(
                      "~/assets/lib/perfect-scrollbar/js/perfect-scrollbar.jquery.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/appjs").Include(
                      "~/assets/js/app.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot").Include(
                      "~/assets/lib/jquery-flot/jquery.flot.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-pie").Include(
                      "~/assets/lib/jquery-flot/jquery.flot.pie.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-time").Include(
                      "~/assets/lib/jquery-flot/jquery.flot.time.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-resize").Include(
                      "~/assets/lib/jquery-flot/jquery.flot.resize.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-orderBars").Include(
                      "~/assets/lib/jquery-flot/plugins/jquery.flot.orderBars.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/curvedLines").Include(
                      "~/assets/lib/jquery-flot/plugins/curvedLines.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-tooltip").Include(
                      "~/assets/lib/jquery-flot/plugins/jquery.flot.tooltip.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-sparkline").Include(
                      "~/assets/lib/jquery.sparkline/jquery.sparkline.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-countUp").Include(
                      "~/assets/lib/countup/countUp.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                      "~/assets/lib/jquery-ui/jquery-ui.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-vmap").Include(
                      "~/assets/lib/jqvmap/jquery.vmap.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-vmap-world").Include(
                      "~/assets/lib/jqvmap/maps/jquery.vmap.world.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/appcss").Include(
                      "~/assets/css/app.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/perfectscrollbar").Include(
                      "~/assets/lib/perfect-scrollbar/css/perfect-scrollbar.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/iconicfont").Include(
                      "~/assets/lib/material-design-icons/css/material-design-iconic-font.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/jvectormap").Include(
                      "~/assets/lib/jquery.vectormap/jquery-jvectormap-1.2.2.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/jqvmap").Include(
                      "~/assets/lib/jqvmap/jqvmap.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/bootstrap-datepicker").Include(
                      "~/assets/lib/datetimepicker/css/bootstrap-datetimepicker.min.css"
                      ));
        }
    }
}
