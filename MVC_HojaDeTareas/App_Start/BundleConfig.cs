using System.Web;
using System.Web.Optimization;

namespace MVC_HojaDeTareas
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));




            bundles.Add(new StyleBundle("~/Content/BlackSheet/css").Include("~/Content/bootstrap.css"
                                                                          , "~/Content/sb-admin.css"
                                                                          , "~/Content/plugins/morris.css"
                                                                          , "~/font-awesome/css/font-awesome.css"
                                                                          , "~/Content/bootstrap-datetimepicker.css"
                                                                          , "~/Content/AppBS.css"
                                                             ));




            bundles.Add(new ScriptBundle("~/Script/BlackShet/js").Include("~/Scripts/jquery-{version}.js"
                                                                        , "~/Scripts/bootstrap.js"                                                                        
                                                                        , "~/Scripts/respond.js"
                                                                        , "~/Scripts/plugins/morris/raphaeljs"
                                                                        , "~/Scripts/moment-with-locales.js"
                                                                        ,"~/Scripts/bootstrap-datetimepicker.js"
                                                                        , "~/Scripts/appBS.js"
                                                                        //, "~/Scripts/plugins/morris/morris.js"
                                                                        //, "~/Scripts/plugins/morris/morris-data.js"
                                                                        ));



        }
    }
}
