using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Game_suit.Startup))]
namespace Game_suit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
