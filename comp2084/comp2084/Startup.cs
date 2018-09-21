using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp2084.Startup))]
namespace comp2084
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
