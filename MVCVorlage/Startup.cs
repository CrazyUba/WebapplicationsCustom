using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCVorlage.Startup))]
namespace MVCVorlage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
