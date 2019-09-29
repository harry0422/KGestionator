using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;

namespace KGestionator.Infrastructure.Repositories.NHibernate.Commons
{
    public static class NhSessionFactory
    {
        public static ISessionFactory Create(string connectionString)
        {
            try
            {
                return Fluently.Configure()
                  .Database(OracleClientConfiguration.Oracle10.ConnectionString(connectionString))
                  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<BitacoraMap>())
                  //.ExposeConfiguration(cfg => { new SchemaExport(cfg).Create(false, true); })
                  .BuildSessionFactory();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}