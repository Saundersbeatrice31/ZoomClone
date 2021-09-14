using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZoomClone.Startup))]
namespace ZoomClone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
