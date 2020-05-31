using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidMVC.Startup))]
namespace VidMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
