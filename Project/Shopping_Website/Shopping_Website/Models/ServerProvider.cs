using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Shopping_Website.Models
{
    public class ServerProvider : OAuthAuthorizationServerProvider
    {
        Shopping_DBEntities db = new Shopping_DBEntities();
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();//validate the client for authentication
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            UserModel u = new UserModel(); //role as int 1,2
            var res = u.ValidateUser(context.UserName, context.Password);

            if (res == null)
            {
                context.SetError("Invalid ", "Give correct pass/email");
                 
            }

            var name = db.RoleDetails.FirstOrDefault(x => x.Id==res.Role);//find the role name of user 

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Role, name.Name));
            identity.AddClaim(new Claim(ClaimTypes.Name, res.Username));
            identity.AddClaim(new Claim("Email", res.Email));
            context.Validated(identity);
        }
    }
}