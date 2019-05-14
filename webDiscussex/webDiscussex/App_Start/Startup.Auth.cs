﻿using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(webDiscussex.App_Start.Startup))]

namespace webDiscussex.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Para obter mais informações sobre como configurar seu aplicativo, visite https://go.microsoft.com/fwlink/?LinkID=316888
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);
            
            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "114939003485-s5ne981iaavopp7op4t51b25tkih1eg0.apps.googleusercontent.com",
                ClientSecret = "kDvwf2ymzHLvW_4GA8T5gEmP",
                CallbackPath = new PathString("/GoogleLoginCallback"),
                Provider = new GoogleOAuth2AuthenticationProvider()
                {
                    OnAuthenticated = (context) =>
                    {
                        context.Identity.AddClaim(new Claim("urn:google:accesstoken", context.AccessToken,
                            ClaimValueTypes.String, "Google"));
                        return Task.FromResult(0);
                    }
                }


            });


        }
    }
}
