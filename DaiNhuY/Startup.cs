using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaiNhuY.Startup))]
namespace DaiNhuY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
