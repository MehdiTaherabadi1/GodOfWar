using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Frameowork.Application;
using Frameowork.Core;
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
        }
    }
}
