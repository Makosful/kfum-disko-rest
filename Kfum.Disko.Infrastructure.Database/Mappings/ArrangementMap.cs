using Kfum.Disko.Core.Entities;
using Kfum.Disko.Infrastructure.Database.Mappings.Abstractions;

namespace Kfum.Disko.Infrastructure.Database.Mappings;

public class ArrangementMap : NHibernateMap<Arrangement>
{
    public ArrangementMap()
    {
        Map(x => x.Titel);
        Map(x => x.Description);
        Map(x => x.IsActive);
    }
}