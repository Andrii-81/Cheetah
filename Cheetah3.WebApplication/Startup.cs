using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cheetah3.WebApplication.Startup))]
namespace Cheetah3.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
