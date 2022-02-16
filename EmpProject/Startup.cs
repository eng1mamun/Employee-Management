using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpProject.Startup))]
namespace EmpProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
