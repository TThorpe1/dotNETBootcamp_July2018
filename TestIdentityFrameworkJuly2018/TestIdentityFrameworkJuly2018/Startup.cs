using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIdentityFrameworkJuly2018.Startup))]
namespace TestIdentityFrameworkJuly2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
