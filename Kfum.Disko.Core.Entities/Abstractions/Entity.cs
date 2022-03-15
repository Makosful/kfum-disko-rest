namespace Kfum.Disko.Core.Entities.Abstractions;

public abstract class Entity
{
    public virtual Guid Id { get; set; }

    public virtual bool Deleted { get; set; }
}