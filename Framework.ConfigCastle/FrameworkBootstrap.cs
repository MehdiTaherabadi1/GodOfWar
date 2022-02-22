using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Frameowork.Application;
using Frameowork.Core;
using Framework.CastleWindsor;

namespace Framework.ConfigCastle
{
    public class FrameworkBootstrap
    {
        public static void Config(IWindsorContainer windsorContainer)
        {
            windsorContainer.Register(Component.For<IServiceLocator>()
                .Instance(new WindsorServiceLocator(windsorContainer))
                .LifestyleSingleton());

            windsorContainer.Register(Component.For<ICommandBus>()
                .ImplementedBy<CommandBus>().LifestyleSingleton());
        }
    }
}
