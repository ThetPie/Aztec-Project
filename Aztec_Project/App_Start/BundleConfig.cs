using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace Aztec_Project
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/ajaxPrefilters.js",
                "~/Scripts/app/app.bindings.js",
                "~/Scripts/app/app.datamodel.js",
                "~/Scripts/app/app.viewmodel.js",
                "~/Scripts/app/home.viewmodel.js",
                "~/Scripts/app/login.viewmodel.js",
                "~/Scripts/app/register.viewmodel.js",
                "~/Scripts/app/registerExternal.viewmodel.js",
                "~/Scripts/app/manage.viewmodel.js",
                "~/Scripts/app/userInfo.viewmodel.js",
                "~/Scripts/app/_run.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/Layout.js",
                "~/Scripts/sgrid.js",
                "~/Scripts/jquery.js",
                "~/Scripts/docs.js",
                "~/Scripts/main.js",
                "~/Scripts/popper.js",
                "~/Scripts/select2.min.js",
                "~/Scripts/daterangepicker.js",
                "~/Scripts/moment.min.js",
                "~/Scripts/countdowntime.js",
                "~/Scripts/jquery-1.11.0.min.js",
                "~/Scripts/jquery-3.2.1.min.js",
                "~/Scripts/animsition.min.js",    
                "~/Scripts/jquery.seat-charts.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                  "~/Content/Layout.css",
                 "~/Content/form.css",
                 "~/Content/sidebar.css",
                 "~/Content/style.css",
                 "~/Content/sgrid.css",
                 "~/Content/font-awesome.css",
                 "~/Content/bootstrap-social.css",
                 "~/Content/sgrid.css",
                 "~/Content/Signup/main.css",
                 "~/Content/Signup/font-awesome.min.css",
                 "~/Content/Signup/util.css",
                 "~/Content/Signup/animate.css",
                 "~/Content/Signup/animsition.min.css",
                 "~/Content/bootstrap.min.css",
                 "~/Content/Signup/humburgers.min.css",
                 "~/Content/Signup/daterangepicker.css",
                 "~/Content/Signup/select2.min.css",
                 "~/Content/Signup/material-design-iconic-font.min.css",
                 "~/Content/simple-sidebar.css",
                 "~/Content/Footer-with-map.css",
                 "~/Content/Site.css"));
        }
    }
}
