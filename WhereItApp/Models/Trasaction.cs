using System;
using System.Collections.Generic;

namespace WhereItApp.Models;

public partial class Trasaction
{
    public int Id { get; set; }

    public DateTime TransactionTime { get; set; }

    public int UserId { get; set; }

    public int ItemId { get; set; }

    public int LocationId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
