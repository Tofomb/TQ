using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TQ.Startup))]
namespace TQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
