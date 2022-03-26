using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Windsor;
using Framework.ConfigCastle;
using ServiceHost.App_Start;
using UOM.Config.Castle;

namespace ServiceHost
{
    public static class HostConfigurator
    {
        public static void Config(HttpConfiguration configuration)
        {
            var container = new WindsorContainer();
            UomBootstrapper.Config(container);
            FrameworkBootstrapper.Config(container, "DBConnection");

            var castleActivator = new CastleControllerActivator(container);
            configuration
                .Services.Replace(typeof(IHttpControllerActivator), castleActivator);

            configuration.Services.Replace(typeof(IHttpControllerSelector),
                new CqsControllerSelector(configuration));
        }
    }
}