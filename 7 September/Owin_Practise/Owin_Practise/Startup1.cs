using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Owin_Practise.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(Owin_Practise.Startup1))]

namespace Owin_Practise
{
    public class Startup1
    {

        public void Configuration(IAppBuilder app)
        {

            app.UseCors(CorsOptions.AllowAll);
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
            {


                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                Provider = new ServerProvider()

            };
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration c = new HttpConfiguration();
            WebApiConfig.Register(c);
        }
    }
}