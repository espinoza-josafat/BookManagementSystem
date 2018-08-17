using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BookManagementSystem.Web.Startup))]
namespace BookManagementSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}