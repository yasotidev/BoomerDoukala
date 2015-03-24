using System.Web.Http;

namespace Doukala
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services Web API
            config.EnableSystemDiagnosticsTracing();
            // Configurez Web API pour utiliser uniquement l’authentification par jeton de support.
            // Utilisez la casse mixte pour les données JSON.

            // Routes Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
