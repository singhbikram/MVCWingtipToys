using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWingtipToys.Startup))]
namespace MVCWingtipToys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
