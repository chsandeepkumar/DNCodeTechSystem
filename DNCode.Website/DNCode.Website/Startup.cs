using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNCode.Website.Startup))]
namespace DNCode.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
