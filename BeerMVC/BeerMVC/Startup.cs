using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerMVC.Startup))]
namespace BeerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
