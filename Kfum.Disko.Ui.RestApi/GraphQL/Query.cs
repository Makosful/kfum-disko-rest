using Kfum.Disko.Core.ApplicationServices.Interfaces;
using Kfum.Disko.Core.Entities;

namespace Kfum.Disko.Ui.RestApi.GraphQL;

public class Query
{
    [UseFiltering]
    [UseSorting]
    public IQueryable<Member> GetMember([Service] IMemberService service)
    {
        return service.MemberQuery();
    }

    [UseFiltering]
    [UseSorting]
    public IQueryable<Arrangement> GetArrangements([Service] IArrangementService service)
    {
        return service.ArrangementQuery();
    }
}