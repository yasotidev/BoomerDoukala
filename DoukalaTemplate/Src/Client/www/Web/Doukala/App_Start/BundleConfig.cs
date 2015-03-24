
using System.Web.Optimization;

namespace Doukala
{
    public class BundleConfig
    {
        // Pour plus d’informations sur le regroupement, rendez-vous sur http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
               "~/Assets/js/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
               "~/Assets/js/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
               "~/Assets/js/bootstrap/bootstrap.js",
               "~/Assets/js/respond/respond.js"));

           
            
            bundles.Add(new StyleBundle("~/Assets/bootstrap").Include(
                  "~/Assets/css/themes/bootstrap/*.css"));

            bundles.Add(new StyleBundle("~/Assets/app").Include(
                 "~/Assets/css/themes/doukala/*.css")); 
        }
    }
}
