using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShowReel.Startup))]
namespace ShowReel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
