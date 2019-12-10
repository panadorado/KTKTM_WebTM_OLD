using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KTM_WebTM.Startup))]
namespace KTM_WebTM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
