using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TunisiaMallWeb.Startup))]
namespace TunisiaMallWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
