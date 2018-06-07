using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Public_NAA.Startup))]
namespace Public_NAA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
