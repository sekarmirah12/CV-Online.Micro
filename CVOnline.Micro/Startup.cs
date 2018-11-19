using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVOnline.Micro.Startup))]
namespace CVOnline.Micro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
