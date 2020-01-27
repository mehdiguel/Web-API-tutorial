using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_API_tutorial.Startup))]
namespace Web_API_tutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
