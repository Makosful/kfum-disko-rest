using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Kfum.Disko.Core;
using NHibernate;
using NHibernate.Caches.CoreMemoryCache;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace Kfum.Disko.Infrastructure.Database;

public class NHibernateSessionManager
{
    private static ISessionFactory Factory { get; set; }
    public static string ConnectionString { get; set; }

    private static ISessionFactory GetFactory<T>() where T : ICurrentSessionContext
    {
        return Fluently.Configure()
            .Database(MySQLConfiguration.Standard.ConnectionString(c => c.Is(ConnectionString)))
            .Cache(c => c.UseQueryCache().ProviderClass<CoreMemoryCacheProvider>().UseSecondLevelCache())
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<IAssemblyMarker>())
            .ExposeConfiguration(x => new SchemaUpdate(x).Execute(true, true))
            .CurrentSessionContext<T>().BuildSessionFactory();
    }

    public static ISession GetCurrentSession()
    {
        try
        {
            if (CurrentSessionContext.HasBind(Factory))
                return Factory.GetCurrentSession();
        }
        catch
        {
            Factory = GetFactory<ThreadStaticSessionContext>();
        }

        var session = Factory.OpenSession();
        CurrentSessionContext.Bind(session);

        return session;
    }
}