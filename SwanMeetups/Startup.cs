using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwanMeetups.Startup))]
namespace SwanMeetups
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
