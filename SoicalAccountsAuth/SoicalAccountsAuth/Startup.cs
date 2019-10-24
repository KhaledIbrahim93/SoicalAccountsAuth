using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoicalAccountsAuth.Startup))]
namespace SoicalAccountsAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
