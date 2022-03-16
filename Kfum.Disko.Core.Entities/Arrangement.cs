using Kfum.Disko.Core.Entities.Abstractions;

namespace Kfum.Disko.Core.Entities;

public class Arrangement : Entity
{
    public virtual bool IsActive { get; set; }

    public virtual string Title { get; set; }

    /// <summary>
    ///     The date this Arrangement takes place. Only the date is used.
    /// </summary>
    public virtual DateTime Date { get; set; }

    /// <summary>
    ///     The time the Arrangement starts. Only the time is used.
    /// </summary>
    public virtual DateTime StartTime { get; set; }

    /// <summary>
    ///     The time the Arrangement ends. Only the time is used.
    /// </summary>
    public virtual DateTime EndTime { get; set; }

    /// <summary>
    ///     The time Members can enter the Arrangement
    /// </summary>
    public virtual DateTime DoorsOpen { get; set; }

    /// <summary>
    ///     Unused
    /// </summary>
    public virtual int OnlineSale { get; set; }

    /// <summary>
    ///     Price for an unregistered member
    /// </summary>
    public virtual int FirstEntry { get; set; }

    /// <summary>
    ///     Price for an registered member
    /// </summary>
    public virtual int NormalEntry { get; set; }

    /// <summary>
    ///     Price plus penalty for not bring card
    /// </summary>
    public virtual int NormalEntryWithoutCard { get; set; }

    /// <summary>
    ///     Free entry, plus penalty for losing card
    /// </summary>
    public virtual int FreeEntryWithoutCard { get; set; }

    /// <summary>
    ///     Special price for birthdays
    /// </summary>
    public virtual int BirthdayEntry { get; set; }

    /// <summary>
    ///     Member capacity
    /// </summary>
    public virtual int Capacity { get; set; }

    public virtual bool IsOnlineSale { get; set; }

    /// <summary>
    ///     Name of the location
    /// </summary>
    public virtual string Location { get; set; }

    /// <summary>
    ///     The address of the Arrangement
    /// </summary>
    public virtual string Address { get; set; }

    public virtual string Description { get; set; }

    /// <summary>
    ///     Groups that can attend this arrangement
    /// </summary>
    public virtual IList<Group> Groups { get; set; }
}