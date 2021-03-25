using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(@default.aspx.Startup))]
namespace @default.aspx
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
