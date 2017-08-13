using System.Web.Optimization;

namespace ProjetoFlavio.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
           BundleTable.EnableOptimizations = true; //Habilitar o manificar os arquivos ll
            bundles.Add(new ScriptBundle("~/teste")
                .IncludeDirectory("~/Content/js",".js",true));
            bundles.Add(new ScriptBundle("~/bundles/comum")
                .Include("~/Content/js/*.js"));

            //Sempre usar o diretorio virtual "~/Content/css" quando tiver imagem no css, pois só assim para funcionar
        }
    }
}