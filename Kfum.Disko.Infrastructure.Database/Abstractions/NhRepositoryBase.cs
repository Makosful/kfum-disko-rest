using Kfum.Disko.Core.DomainServices.Abstractions;
using Kfum.Disko.Core.Entities.Abstractions;
using NHibernate;
using NHibernate.Linq;

namespace Kfum.Disko.Infrastructure.Database.Abstractions;

public abstract class NhRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    private ISession? _internalSession;

    private ISession Session
    {
        get => _internalSession ?? NHibernateSessionManager.GetCurrentSession();
        set => _internalSession = value;
    }

    IQueryable<TEntity> IRepository<TEntity>.Query()
    {
        return Session.Query<TEntity>()
            .WithOptions(x => x.SetCacheable(true))
            .WithOptions(x => x.SetCacheMode(CacheMode.Normal))
            .Where(x => !x.Deleted);
    }

    void IRepository<TEntity>.SaveOrUpdate(TEntity entity)
    {
        using var trans = Session.BeginTransaction();

        try
        {
            Session.SaveOrUpdate(entity);
            trans.Commit();
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    void IRepository<TEntity>.SaveOrUpdate(IEnumerable<TEntity> entities)
    {
        using var trans = Session.BeginTransaction();
        try
        {
            Session.SaveOrUpdate(entities);
            trans.Commit();
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    void IRepository<TEntity>.Delete(TEntity entity)
    {
        IRepository<TEntity> repository = this;
        entity.Deleted = true;

        repository.SaveOrUpdate(entity);
    }

    void IRepository<TEntity>.HardDelete(TEntity entity)
    {
        Session.Delete(entity);
    }
}