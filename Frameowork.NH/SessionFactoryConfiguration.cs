using System.Data;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;

namespace Framework.Domain
{
    public static class SessionFactoryConfiguration
    {
        public static ISessionFactory Create(string connectionStringName, Assembly mappingAssembly)
        {
            Configuration configuration = new Configuration();

            configuration.DataBaseIntegration(cfg =>
            {
                cfg.Dialect<MsSql2012Dialect>();
                cfg.Driver<SqlClientDriver>();
                cfg.ConnectionString = "Server=.;Database=GodOfWarDB;Trusted_Connection=True;";
                cfg.IsolationLevel = IsolationLevel.ReadCommitted;
            });

            ModelMapper modelMapper = new ModelMapper();
            modelMapper.AddMappings(mappingAssembly.GetExportedTypes());
            HbmMapping hbmMapping = modelMapper.CompileMappingForAllExplicitlyAddedEntities();
            configuration.AddDeserializedMapping(hbmMapping, "test");


            return configuration.BuildSessionFactory();
        }
    }
}