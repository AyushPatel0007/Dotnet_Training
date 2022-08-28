using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filter_Authent.Startup))]
namespace Filter_Authent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
