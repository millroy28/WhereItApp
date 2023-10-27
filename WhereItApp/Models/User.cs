using System;
using System.Collections.Generic;

namespace WhereItApp.Models;

public partial class User
{
    public int Id { get; set; }

    public string AspNetUserId { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string UserName { get; set; } = null!;

    public bool DefaultPrivate { get; set; }

    public virtual AspNetUser AspNetUser { get; set; } = null!;

    public virtual ICollection<Item> ItemCreatedByNavigations { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemModifiedByNavigations { get; set; } = new List<Item>();

    public virtual ICollection<Location> LocationCreatedByNavigations { get; set; } = new List<Location>();

    public virtual ICollection<Location> LocationModifiedByNavigations { get; set; } = new List<Location>();

    public virtual ICollection<Trasaction> Trasactions { get; set; } = new List<Trasaction>();

    public virtual ICollection<UserRealm> UserRealms { get; set; } = new List<UserRealm>();
}
