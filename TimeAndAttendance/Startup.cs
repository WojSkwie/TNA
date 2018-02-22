using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeAndAttendance.Startup))]
namespace TimeAndAttendance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
