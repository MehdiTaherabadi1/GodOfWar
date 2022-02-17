using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Domain;
using NHibernate;
using UOM.Application;
using UOM.Domain.Model.Dimensions;
using UOM.Domain.Persistence.NH.Mappings;
using UOM.Domain.Persistence.NH.Repositories;
using UOM.Interface.RestApi;

namespace UOM.Config.Castle
{
    public static class UomBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Component.For<IDimensionService>()
                .ImplementedBy<DimensionService>()
                .LifestylePerWebRequest());

            container.Register(Component.For<DimensionsController>()
                .LifestyleTransient());

            ConfigPersistence(container);
        }

        private static void ConfigPersistence(IWindsorContainer container)
        {
            ISessionFactory sessionFactory = SessionFactoryConfiguration.Create("DBConnection", typeof(DimensionMapping).Assembly);

            container.Register(Component.For<ISession>().UsingFactoryMethod(f => sessionFactory.OpenSession()).LifestylePerWebRequest());

            container.Register(Component.For<IDimensionRepository>().ImplementedBy<DimensionRepository>()
                .LifestylePerWebRequest());
        }
    }
}
