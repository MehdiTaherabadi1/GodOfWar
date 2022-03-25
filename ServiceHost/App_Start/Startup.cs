using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(ServiceHost.App_Start.Startup))]

namespace ServiceHost.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            SetupAccessTokenValidation(app);

            WebApiConfig.Register(configuration);
            HostConfigurator.Config(configuration);
            app.UseWebApi(configuration);
        }

        private static void SetupAccessTokenValidation(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(
                            new IdentityServerBearerTokenAuthenticationOptions
                            {
                                Authority = "https://localhost:44310"
                            });
        }
    }
}
