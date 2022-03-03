using Kfum.Disko.Core.Entities;

namespace Kfum.Disko.Core.ApplicationServices.Interfaces;

public interface IArrangementService
{
    IQueryable<Arrangement> ArrangementQuery();

    Arrangement SetActiveStatus(long inputId, bool inputActive);
}