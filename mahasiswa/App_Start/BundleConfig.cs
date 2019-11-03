using System.Web;
using System.Web.Optimization;

namespace mahasiswa
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
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.min.css"));

            // Add Datatables
            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                      "~/Content/DataTables/css/dataTables.bootstrap4.min.css"));

            bundles.Add(new ScriptBundle("~/bundels/datatables").Include(
                "~/Scripts/Datatables/jquery.dataTables.min.js",
                "~/Scripts/Datatables/dataTables.bootstrap4.min.js"));

            // Add Toastr
            bundles.Add(new StyleBundle("~/Content/toastr").Include(
                      "~/Content/toastr.css"));

            bundles.Add(new ScriptBundle("~/bundels/toastr").Include(
                "~/Scripts/toastr.js"));
        }
    }
}
