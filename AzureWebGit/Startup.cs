using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebGit.Startup))]
namespace AzureWebGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
