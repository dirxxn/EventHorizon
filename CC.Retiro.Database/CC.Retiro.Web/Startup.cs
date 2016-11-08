using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CC.Retiro.Web.Startup))]
namespace CC.Retiro.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
