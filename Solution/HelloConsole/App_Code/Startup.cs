using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloConsole.Startup))]
namespace HelloConsole
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
