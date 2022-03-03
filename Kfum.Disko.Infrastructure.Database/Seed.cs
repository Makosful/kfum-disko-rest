using Kfum.Disko.Core.Entities;
using NHibernate;
using NHibernate.Linq;

namespace Kfum.Disko.Infrastructure.Database;

public static class Seed
{
    public static void SeedDatabase(ISession session)
    {
        SeedMembers(session);
    }

    private static void SeedMembers(ISession session)
    {
        if (!session.IsOpen)
            throw new InvalidOperationException("Session is closed");

        using var trans = session.BeginTransaction();

        session.Query<Member>().Delete();

        session.SaveOrUpdate(new Member {Name = "Foo", Deleted = false});
        session.SaveOrUpdate(new Member {Name = "Bar", Deleted = true});
        session.SaveOrUpdate(new Member {Name = "FooBar", Deleted = false});
        session.SaveOrUpdate(new Member {Name = "Zar", Deleted = false});

        trans.Commit();
    }
}