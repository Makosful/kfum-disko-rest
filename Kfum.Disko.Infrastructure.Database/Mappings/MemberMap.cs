using Kfum.Disko.Core.Entities;
using Kfum.Disko.Infrastructure.Database.Mappings.Abstractions;

namespace Kfum.Disko.Infrastructure.Database.Mappings;

public class MemberMap : NHibernateMap<Member>
{
    public MemberMap()
    {
        Map(x => x.FirstName);
        Map(x => x.LastName);
        Map(x => x.Gender).Nullable();
        Map(x => x.Birthday).Nullable();

        Map(x => x.Address);
        Map(x => x.Address2).Nullable();
        Map(x => x.ZipCode);

        Map(x => x.Email).Nullable();
        Map(x => x.Mobile).Nullable();
        Map(x => x.Phone).Nullable();

        HasOne(x => x.Group);
    }
}