using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFootBallClub.Startup))]
namespace WebFootBallClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
