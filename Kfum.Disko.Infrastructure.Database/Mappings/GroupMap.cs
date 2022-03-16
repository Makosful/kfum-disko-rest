using Kfum.Disko.Core.Entities;
using Kfum.Disko.Infrastructure.Database.Mappings.Abstractions;

namespace Kfum.Disko.Infrastructure.Database.Mappings;

public class GroupMap : NHibernateMap<Group>
{
    public GroupMap()
    {
        Map(x => x.Title);

        HasMany(x => x.Members).Inverse();
    }
}