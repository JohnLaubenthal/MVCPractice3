using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPractice3.Startup))]
namespace MVCPractice3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
