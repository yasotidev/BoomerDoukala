using System.Web.Http;

namespace Bakoukala
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services Web API
            // Configurez Web API pour utiliser uniquement l’authentification par jeton de support.
            config.EnableSystemDiagnosticsTracing();
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
