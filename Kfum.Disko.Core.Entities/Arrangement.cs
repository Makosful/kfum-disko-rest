using Kfum.Disko.Core.Entities.Abstractions;

namespace Kfum.Disko.Core.Entities;

public class Arrangement : Entity
{
    public virtual string Titel { get; set; }

    public virtual string Description { get; set; }

    public virtual bool IsActive { get; set; }
}