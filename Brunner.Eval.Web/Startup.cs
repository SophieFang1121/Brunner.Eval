using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brunner.Eval.Web.Startup))]
namespace Brunner.Eval.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
