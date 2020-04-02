using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.Web.Optimization;

namespace MyProject.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Responsive styles
            bundles.Add(new StyleBundle("~/bundles/responsive/css").Include(
            "~/Content/responsive.css", new CssRewriteUrlTransform()));
            // Slick-theme styles
            bundles.Add(new StyleBundle("~/bundles/slick/css").Include(
            "~/Content/slick.css", new CssRewriteUrlTransform()));
            // Slick styles
            bundles.Add(new StyleBundle("~/bundles/slick-theme/css").Include(
            "~/Content/slick-theme.css", new CssRewriteUrlTransform()));
            // Personal styles
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
            "~/Content/style.css", new CssRewriteUrlTransform()));
            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
            "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
            "~/Scripts/bootstrap.min.js"));
            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
            "~/Scripts/jquery-3.3.1.min.js"));
            // Unobtrusive
            bundles.Add(new ScriptBundle("~/bundles/unobtrusive/js").Include(
            "~/Scripts/jquery.unobtrusive-ajax.min.js"));
            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/validation/js").Include(
            "~/Scripts/jquery.validate.min.js"));
            // Popper
            bundles.Add(new ScriptBundle("~/bundles/popper/js").Include(
            "~/Scripts/popper.min.js"));
            // Slick
            bundles.Add(new ScriptBundle("~/bundles/slick/js").Include(
            "~/Scripts/slick.js"));
            // Filtering
            bundles.Add(new ScriptBundle("~/bundles/filtering/js").Include(
            "~/Scripts/filtering.js"));
        }
    }
}