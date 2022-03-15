using Kfum.Disko.Core.Entities;

namespace Kfum.Disko.Core.ApplicationServices.Interfaces;

public interface IArrangementService
{
    IQueryable<Arrangement> ArrangementQuery();

    Arrangement SetActiveStatus(Guid inputId, bool inputActive);
}