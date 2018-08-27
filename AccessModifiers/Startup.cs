using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccessModifiers.Startup))]
namespace AccessModifiers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
