using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HR_app.Startup))]
namespace HR_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
