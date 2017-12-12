namespace PIM.Web.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                        "~/Scripts/jquery-2.1.1.js",
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery-ui-1.10.4.min.js",
                        "~/Scripts/jquery-ui.custom.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/inspinia.js",
                        "~/Scripts/plugins/metisMenu/jquery.metisMenu.js",
                        "~/Scripts/plugins/slimscroll/jquery.slimscroll.min.js",
                        "~/Scripts/plugins/toastr/toastr.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/plugins").Include(
                        "~/Scripts/plugins/highcharts/highcharts.js",
                        "~/Scripts/plugins/highcharts/exporting.js",
                        "~/Scripts/plugins/dataTables/datatables.min.js",
                        "~/Scripts/plugins/pace/pace.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/custom").Include(
                        "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/plugins/toastr/toastr.min.css",
                        "~/Content/animate.css",
                        "~/Content/style.css",
                        "~/font-awesome/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/datatable").Include(
                        "~/Content/plugins/dataTables/datatables.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
            //~/Scripts/Inputmask/dependencyLibs/inputmask.dependencyLib.js",  //if not using jquery
            "~/Scripts/Inputmask/inputmask.js",
            "~/Scripts/Inputmask/jquery.inputmask.js",
            "~/Scripts/Inputmask/inputmask.extensions.js",
            "~/Scripts/Inputmask/inputmask.date.extensions.js",
            //and other extensions you want to include
            "~/Scripts/Inputmask/inputmask.numeric.extensions.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}