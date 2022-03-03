using FluentNHibernate.Mapping;
using Kfum.Disko.Core.Entities.Abstractions;

namespace Kfum.Disko.Infrastructure.Database.Mappings.Abstractions;

public abstract class NHibernateMap<TEntity> : ClassMap<TEntity> where TEntity : Entity
{
    protected NHibernateMap()
    {
        Cache.ReadWrite();
        Id(x => x.Id).GeneratedBy.Identity();
        Map(x => x.Deleted);
    }
}