using Owin;

namespace Doukala
{
    public partial class Startup
    {
        public void ConfigureSignalR(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
