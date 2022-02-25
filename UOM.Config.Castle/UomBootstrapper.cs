using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Frameowork.Application;
using Frameowork.NH;
using NHibernate;
using UOM.Application;
using UOM.Domain.Model.Dimensions;
using UOM.Interface.RestApi;
using UOM.Persistence.NH.Mappings;
using UOM.Persistence.NH.Repositories;

namespace UOM.Config.Castle
{
    public static class UomBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Classes.FromAssemblyContaining<DimensionCommandHandler>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithServiceFromInterface()
                .LifestyleTransient());

            container.Register(Component.For<DimensionsController>()
                .LifestyleTransient());

            ConfigPersistence(container);
        }

        private static void ConfigPersistence(IWindsorContainer container)
        {
            var sessionFactory = SessionFactoryConfiguration.Create("DBConnection", typeof(DimensionMapping).Assembly);

            container.Register(Component.For<ISession>()
                .UsingFactoryMethod(a => sessionFactory.OpenSession())
                .LifestyleScoped());

            container.Register(Component.For<IDimensionRepository>()
                .ImplementedBy<DimensionRepository>()
                .LifestyleScoped());
        }
    }
}
