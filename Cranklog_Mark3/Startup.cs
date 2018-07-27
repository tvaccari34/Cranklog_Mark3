using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cranklog_Mark3.Startup))]
namespace Cranklog_Mark3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
