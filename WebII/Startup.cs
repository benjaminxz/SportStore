using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebII.Startup))]
namespace WebII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
