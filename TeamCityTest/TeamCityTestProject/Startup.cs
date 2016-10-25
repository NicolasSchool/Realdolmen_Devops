using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityTestProject.Startup))]
namespace TeamCityTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
