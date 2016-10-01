using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyBikeWebApp.Startup))]
namespace EasyBikeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
