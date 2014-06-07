using Microsoft.Owin;
using Owin;
using Web.Security;

[assembly: OwinStartup(typeof(Startup))]
namespace Web.Security
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
