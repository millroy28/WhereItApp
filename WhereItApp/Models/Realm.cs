using System;
using System.Collections.Generic;

namespace WhereItApp.Models;

public partial class Realm
{
    public int Id { get; set; }

    public bool? IsActive { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<UserRealm> UserRealms { get; set; } = new List<UserRealm>();
}
