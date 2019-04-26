using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFinance.Presentation.Startup))]
namespace MyFinance.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
