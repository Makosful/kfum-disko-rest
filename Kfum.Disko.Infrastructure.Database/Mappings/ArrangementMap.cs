using Kfum.Disko.Core.Entities;
using Kfum.Disko.Infrastructure.Database.Mappings.Abstractions;

namespace Kfum.Disko.Infrastructure.Database.Mappings;

public class ArrangementMap : NHibernateMap<Arrangement>
{
    public ArrangementMap()
    {
        Map(x => x.IsActive);
        Map(x => x.Title);
        Map(x => x.Date);
        Map(x => x.StartTime);
        Map(x => x.EndTime);
        Map(x => x.DoorsOpen);
        Map(x => x.OnlineSale);
        Map(x => x.FirstEntry);
        Map(x => x.NormalEntry);
        Map(x => x.NormalEntryWithoutCard);
        Map(x => x.FreeEntryWithoutCard);
        Map(x => x.BirthdayEntry);
        Map(x => x.Capacity);
        Map(x => x.IsOnlineSale);
        Map(x => x.Location);
        Map(x => x.Address);
        Map(x => x.Description);
        HasManyToMany(x => x.Groups);
    }
}