using Kfum.Disko.Core.Entities;
using Kfum.Disko.Core.Entities.Enums;
using NHibernate;
using NHibernate.Linq;

namespace Kfum.Disko.Infrastructure.Database;

public static class Seed
{
    public static void SeedDatabase(ISession session)
    {
        SeedMembers(session);
        SeedArrangements(session);
    }

    private static void SeedMembers(ISession session)
    {
        if (!session.IsOpen)
            throw new InvalidOperationException("Session is closed");

        using var trans = session.BeginTransaction();

        session.Query<Member>().Delete();

        session.SaveOrUpdate(new Member
        {
            Deleted = false,
            FirstName = "Foo",
            LastName = "Bar",
            Gender = Gender.Male,
            Address = "Test Street 1",
            ZipCode = "1234"
        });
        session.SaveOrUpdate(new Member
        {
            Deleted = false,
            FirstName = "Lorem",
            LastName = "Ipsum",
            Gender = Gender.Female,
            Address = "Ancient Latin Country 78",
            ZipCode = "5678"
        });
        session.SaveOrUpdate(new Member
        {
            Deleted = false,
            FirstName = "Cthulhu",
            LastName = "The Messenger",
            Gender = Gender.Unknown,
            Address = "Void",
            ZipCode = "XXXX"
        });
        session.SaveOrUpdate(new Member
        {
            Deleted = true,
            FirstName = "John",
            LastName = "Doe",
            Address = "Apple Street 99",
            ZipCode = "9876"
        });

        trans.Commit();
    }

    private static void SeedArrangements(ISession session)
    {
        if (!session.IsOpen)
            throw new InvalidOperationException("Session is closed");

        using var trans = session.BeginTransaction();

        session.Query<Arrangement>().Delete();

        session.SaveOrUpdate(new Arrangement {Titel = "Disko 2020", IsActive = false});
        session.SaveOrUpdate(new Arrangement {Titel = "Disko 2021", IsActive = false});
        session.SaveOrUpdate(new Arrangement {Titel = "Disko 2022", IsActive = true});

        trans.Commit();
    }
}