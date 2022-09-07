using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace WebApi_demo.Models
{
    public class ServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            UserModel u = new UserModel();
            var res = u.ValidateUser(context.UserName, context.Password);
            if (res == null)
            {
                context.SetError("Invalid ", "Give correct pass/email");
                return;
            }
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Role, res.Roles));
            identity.AddClaim(new Claim(ClaimTypes.Name, res.UserName));
            identity.AddClaim(new Claim("Email", res.Email));
            identity.AddClaim(new Claim("Secret key", "12233"));
            context.Validated(identity);
        }
    }
}