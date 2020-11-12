using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Accademy.WebApp.Startup))]
namespace Accademy.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
