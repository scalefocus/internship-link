using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternshipLink.Web.Startup))]
namespace InternshipLink.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
