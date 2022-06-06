using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductDashboard.Startup))]
namespace ProductDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
