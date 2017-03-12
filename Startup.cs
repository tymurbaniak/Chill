using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutorial3.Startup))]
namespace Tutorial3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
