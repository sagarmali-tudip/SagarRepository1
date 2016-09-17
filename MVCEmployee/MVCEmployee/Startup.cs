using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEmployee.Startup))]
namespace MVCEmployee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
