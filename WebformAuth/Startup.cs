using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebformAuth.Startup))]
namespace WebformAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
