using System;
using System.Collections.Generic;

namespace WhereItApp.Models;

public partial class Item
{
    public int Id { get; set; }

    public int LocationId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Trasaction> Trasactions { get; set; } = new List<Trasaction>();
}
