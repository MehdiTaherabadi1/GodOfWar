using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Frameowork.Application;
using Frameowork.Core;
using Frameowork.Core.EventHandling;
using Framework.CastleWindsor;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Framework.ConfigCastle
{
    public class FrameworkBootstrapper
    {
        public static void Config(IWindsorContainer container, string conectionStringKey)
        {
            container.Register(Component.For<IServiceLocator>()
                .Instance(new WindsorServiceLocator(container))
                .LifestyleSingleton());

            container.Register(Component.For<IDbConnection>()
                .Forward<DbConnection>()
                .Forward<SqlConnection>()
                .UsingFactoryMethod(f =>
                {
                    var connectionString = ConfigurationManager.ConnectionStrings[conectionStringKey].ConnectionString;
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    return connection;
                })
                .LifestylePerWebRequest()
                .OnDestroy(f => f.Close()));

            container.Register(Component.For<ICommandBus>()
                .ImplementedBy<CommandBus>()
                .LifestyleSingleton());

            container.Register(Component.For<IEventPublisher>()
                .Forward<IEventListener>()
                .ImplementedBy<EventAggregator>()
                .LifestylePerWebRequest());
        }
    }
}
