using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanielCordova_GitHubDashboard.Startup))]
namespace DanielCordova_GitHubDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
