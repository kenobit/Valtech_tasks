using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameClientServer.Startup))]
namespace GameClientServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
