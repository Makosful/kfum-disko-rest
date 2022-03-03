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
}