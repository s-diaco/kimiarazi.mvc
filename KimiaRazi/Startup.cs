using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KimiaRazi.Startup))]
namespace KimiaRazi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
