// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="">
//   Copyright © 2015 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ProjectTracking.Web
{
    using System.Web;
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css/appstyle").Include("~/Content/css/bootstrap.min.css", 
                "~/Content/css/bootstrap-responsive.min.css",
                "~/Content/css/maruti-style.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/vendor/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
            "~/Scripts/vendor/jquery.ui.custom.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
       "~/Scripts/vendor/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/vendor/angular.js",
                "~/Scripts/vendor/angular-route.js",
                "~/Scripts/app/app.js", "~/Scripts/app/controllers/memberController.js"));
        }
    }
}
