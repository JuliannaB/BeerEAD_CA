using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerMVC5.Startup))]
namespace BeerMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
