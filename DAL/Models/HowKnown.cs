using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HowKnown
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<UserDetail> UserDetails { get; set; } = new List<UserDetail>();
}
