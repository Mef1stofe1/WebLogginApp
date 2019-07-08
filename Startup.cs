using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLogginApp.Startup))]
namespace WebLogginApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
