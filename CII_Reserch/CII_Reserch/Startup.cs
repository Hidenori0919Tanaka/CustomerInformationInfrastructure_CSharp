using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CII_Reserch.Startup))]
namespace CII_Reserch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
