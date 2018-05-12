using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CII.App_Start.Startup))]
namespace MSAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Configuration(app);
        }
    }
}