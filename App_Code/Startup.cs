using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite13.Startup))]
namespace WebSite13
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
