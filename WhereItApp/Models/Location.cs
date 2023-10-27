using System;
using System.Collections.Generic;

namespace WhereItApp.Models;

public partial class Location
{
    public int Id { get; set; }

    public bool? IsActive { get; set; }

    public string Name { get; set; } = null!;

    public int RealmId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual Realm Realm { get; set; } = null!;

    public virtual ICollection<Trasaction> Trasactions { get; set; } = new List<Trasaction>();
}
