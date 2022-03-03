using Kfum.Disko.Core.DomainServices;
using Kfum.Disko.Core.Entities;
using Kfum.Disko.Infrastructure.Database.Abstractions;

namespace Kfum.Disko.Infrastructure.Database.Repositories;

public class MemberRepository : NhRepositoryBase<Member>, IMemberRepository
{
}