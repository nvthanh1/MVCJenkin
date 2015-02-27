using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCJenkins.Startup))]
namespace MVCJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
