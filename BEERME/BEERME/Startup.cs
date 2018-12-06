using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BEERME.Startup))]
namespace BEERME
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
