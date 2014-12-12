using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RatioCalculator.Web.Startup))]
namespace RatioCalculator.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
