using Microsoft.Owin;
using Owin;
using StartupApp;

[assembly: OwinStartup(typeof(Startup))]
namespace StartupApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
