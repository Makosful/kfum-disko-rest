using Kfum.Disko.Core.ApplicationServices.Interfaces;
using Kfum.Disko.Core.DomainServices;
using Kfum.Disko.Core.Entities;

namespace Kfum.Disko.Core.ApplicationServices;

public class ArrangementService : IArrangementService
{
    private readonly IArrangementRepository _repository;

    public ArrangementService(IArrangementRepository repository)
    {
        _repository = repository;
    }

    IQueryable<Arrangement> IArrangementService.ArrangementQuery()
    {
        return _repository.Query();
    }

    Arrangement IArrangementService.SetActiveStatus(long inputId, bool inputActive)
    {
        var arrangement = _repository.Query().FirstOrDefault(x => x.Id == inputId);
        if (arrangement is null) throw new ArgumentNullException();

        arrangement.IsActive = inputActive;
        _repository.SaveOrUpdate(arrangement);
        return arrangement;
    }
}