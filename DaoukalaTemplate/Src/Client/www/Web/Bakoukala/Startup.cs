using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Bakoukala.Startup))]

namespace Bakoukala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigureSignalR(app);
        }
    }
}
