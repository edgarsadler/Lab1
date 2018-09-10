using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWebForms1.Startup))]
namespace HelloWebForms1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
