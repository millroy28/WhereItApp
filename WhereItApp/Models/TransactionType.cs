using System;
using System.Collections.Generic;

namespace WhereItApp.Models;

public partial class TransactionType
{
    public int Id { get; set; }

    public string Transaction { get; set; } = null!;
}
