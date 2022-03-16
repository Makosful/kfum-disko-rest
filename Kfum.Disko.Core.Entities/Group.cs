using Kfum.Disko.Core.Entities.Abstractions;

namespace Kfum.Disko.Core.Entities;

public class Group : Entity
{
    public virtual string Title { get; set; }

    public virtual IList<Member> Members { get; set; }
}