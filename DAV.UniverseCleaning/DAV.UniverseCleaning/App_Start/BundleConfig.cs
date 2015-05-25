﻿using System.Web;
using System.Web.Optimization;

namespace DAV.UniverseCleaning
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

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                      "~/Scripts/kendo/2015.1.318/kendo.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/excoloSlider").Include(
                      "~/Scripts/jquery.excoloSlider.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/jquery.excoloSlider.css",
                      "~/Content/bootstrap.css",
                      "~/Content/menu.css",
                      "~/Content/site.css",
                      "~/Content/kendo/2015.1.318/kendo.metro.min.css",
                      "~/Content/kendo/2015.1.318/kendo.common.min.css"));
        }
    }
}
