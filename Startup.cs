using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HtmlHelperLab.Startup))]
namespace HtmlHelperLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
