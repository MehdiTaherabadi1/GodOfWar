using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Frameowork.Application;
using Frameowork.Core;
using Frameowork.Core.EventHandling;
using Framework.CastleWindsor;

namespace Framework.ConfigCastle
{
    public static class FrameworkBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Component.For<IServiceLocator>()
                .Instance(new WindsorServiceLocator(container))
                .LifestyleSingleton());

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
