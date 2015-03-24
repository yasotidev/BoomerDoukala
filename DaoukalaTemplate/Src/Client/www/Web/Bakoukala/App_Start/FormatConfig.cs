using System.Globalization;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Bakoukala
{
    public class FormatConfig
    {
        public static void ConfigureFormats(HttpConfiguration config)
        {
            // Use 
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            // Remove default XML handler
            var matches = config.Formatters
                .Where(f => f.SupportedMediaTypes
                    .Any(m => m.MediaType
                        .ToString(CultureInfo.InvariantCulture) == "application/xml" ||
                              m.MediaType.ToString(CultureInfo.InvariantCulture) == "text/xml"))
                .ToList();
            foreach (var match in matches)
                config.Formatters.Remove(match);
        }
    }
}