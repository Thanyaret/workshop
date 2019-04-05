using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(workshop.Startup))]
namespace workshop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
