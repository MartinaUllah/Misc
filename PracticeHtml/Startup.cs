using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeHtml.Startup))]
namespace PracticeHtml
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
