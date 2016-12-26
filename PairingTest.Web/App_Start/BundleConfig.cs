using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace PairingTest.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/CSS/bootstrap.min.css",
                     "~/CSS/bootstrap-theme.min.css"));
        }
    }
}
