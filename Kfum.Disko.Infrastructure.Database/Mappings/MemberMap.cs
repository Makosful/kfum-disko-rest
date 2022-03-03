using Kfum.Disko.Core.Entities;
using Kfum.Disko.Infrastructure.Database.Mappings.Abstractions;

namespace Kfum.Disko.Infrastructure.Database.Mappings;

public class MemberMap : NHibernateMap<Member>
{
    public MemberMap()
    {
        Map(x => x.Name);
    }
}