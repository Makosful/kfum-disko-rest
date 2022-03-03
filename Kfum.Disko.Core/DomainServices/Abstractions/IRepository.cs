using Kfum.Disko.Core.Entities.Abstractions;

namespace Kfum.Disko.Core.DomainServices.Abstractions;

public interface IRepository<TEntity> where TEntity : Entity
{
    IQueryable<TEntity> Query();

    void SaveOrUpdate(TEntity entity);

    void SaveOrUpdate(IEnumerable<TEntity> entities);

    void Delete(TEntity entity);

    void HardDelete(TEntity entity);
}