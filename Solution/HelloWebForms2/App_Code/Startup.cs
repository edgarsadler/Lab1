using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWebForms2.Startup))]
namespace HelloWebForms2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
