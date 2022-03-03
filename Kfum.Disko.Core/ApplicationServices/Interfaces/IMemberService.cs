using Kfum.Disko.Core.Entities;

namespace Kfum.Disko.Core.ApplicationServices.Interfaces;

public interface IMemberService
{
    IQueryable<Member> MemberQuery();
}