using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FixedAssetsManagement.Startup))]
namespace FixedAssetsManagement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
