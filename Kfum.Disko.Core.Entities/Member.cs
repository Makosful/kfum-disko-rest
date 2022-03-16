using Kfum.Disko.Core.Entities.Abstractions;
using Kfum.Disko.Core.Entities.Enums;

namespace Kfum.Disko.Core.Entities;

public class Member : Entity
{
    public virtual string FirstName { get; set; }

    public virtual string LastName { get; set; }

    /// <summary>
    ///     Main address of the member
    /// </summary>
    public virtual string Address { get; set; }

    /// <summary>
    ///     Extra address field
    /// </summary>
    public virtual string? Address2 { get; set; }

    public virtual string ZipCode { get; set; }

    /// <summary>
    ///     Note: Only the date is accounted for. The time should be 00:00:00
    /// </summary>
    public virtual DateTime Birthday { get; set; } = DateTime.MinValue;

    public virtual Gender? Gender { get; set; }

    public virtual string? Email { get; set; }

    /// <summary>
    ///     Mobile phone number
    /// </summary>
    public virtual string? Mobile { get; set; }

    /// <summary>
    ///     Landline phone number
    /// </summary>
    public virtual string? Phone { get; set; }

    /// <summary>
    ///     The Group this member belongs to
    /// </summary>
    public virtual Group Group { get; set; }
}