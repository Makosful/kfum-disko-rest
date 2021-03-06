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

        session.SaveOrUpdate(new Arrangement
        {
            IsActive = true,
            Title = "Disko 2022",
            Date = DateTime.Today.AddDays(5),
            StartTime = DateTime.Today.AddDays(5).AddHours(19),
            EndTime = DateTime.Today.AddDays(5).AddHours(22),
            DoorsOpen = DateTime.Today.AddDays(5).AddHours(18).AddMinutes(45),
            OnlineSale = 0,
            FirstEntry = 45,
            NormalEntry = 35,
            NormalEntryWithoutCard = 45,
            FreeEntryWithoutCard = 10,
            BirthdayEntry = 35,
            Capacity = 300,
            IsOnlineSale = false,
            Location = "KFUM & KFUK",
            Address = "Kirkegade 70, 6700 Esbjerg",
            Description = "",
        });
        session.SaveOrUpdate(new Arrangement
        {
            IsActive = false,
            Title = "Disko 2021",
            Date = DateTime.Today.AddDays(5),
            StartTime = DateTime.Today.AddDays(5).AddHours(19).AddYears(-1),
            EndTime = DateTime.Today.AddDays(5).AddHours(22).AddYears(-1),
            DoorsOpen = DateTime.Today.AddDays(5).AddHours(18).AddMinutes(45).AddYears(-1),
            OnlineSale = 0,
            FirstEntry = 45,
            NormalEntry = 35,
            NormalEntryWithoutCard = 45,
            FreeEntryWithoutCard = 10,
            BirthdayEntry = 35,
            Capacity = 300,
            IsOnlineSale = false,
            Location = "KFUM & KFUK",
            Address = "Kirkegade 70, 6700 Esbjerg",
            Description = "",
        });
        session.SaveOrUpdate(new Arrangement
        {
            IsActive = false,
            Title = "Disko 2020",
            Date = DateTime.Today.AddDays(5),
            StartTime = DateTime.Today.AddDays(5).AddHours(19).AddYears(-2),
            EndTime = DateTime.Today.AddDays(5).AddHours(22).AddYears(-2),
            DoorsOpen = DateTime.Today.AddDays(5).AddHours(18).AddMinutes(45).AddYears(-2),
            OnlineSale = 0,
            FirstEntry = 45,
            NormalEntry = 35,
            NormalEntryWithoutCard = 45,
            FreeEntryWithoutCard = 10,
            BirthdayEntry = 35,
            Capacity = 300,
            IsOnlineSale = false,
            Location = "KFUM & KFUK",
            Address = "Kirkegade 70, 6700 Esbjerg",
            Description = "",
        });

        trans.Commit();
    }
}