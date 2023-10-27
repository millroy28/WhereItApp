using System;
using System.Collections.Generic;

namespace WhereItApp.Models;

public partial class UserRealm
{
    public int Id { get; set; }

    public int RealmId { get; set; }

    public int UserId { get; set; }

    public DateTime Created { get; set; }

    public virtual Realm Realm { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
