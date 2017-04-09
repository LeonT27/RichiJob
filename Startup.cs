using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Richi.Shop._1.Startup))]
namespace Richi.Shop._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
