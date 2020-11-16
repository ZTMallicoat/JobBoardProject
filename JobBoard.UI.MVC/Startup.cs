using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobBoard.UI.MVC.Startup))]
namespace JobBoard.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
