using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsDemoApp.Startup))]
namespace JenkinsDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
