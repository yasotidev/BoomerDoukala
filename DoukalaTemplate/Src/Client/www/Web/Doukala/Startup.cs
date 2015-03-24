using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Doukala.Startup))]

namespace Doukala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
