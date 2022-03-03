using Kfum.Disko.Core.ApplicationServices.Interfaces;
using Kfum.Disko.Core.DomainServices;
using Kfum.Disko.Core.Entities;

namespace Kfum.Disko.Core.ApplicationServices;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _repository;

    public MemberService(IMemberRepository repository)
    {
        _repository = repository;
    }

    IQueryable<Member> IMemberService.MemberQuery()
    {
        return _repository.Query();
    }
}