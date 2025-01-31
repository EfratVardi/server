using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TypeGame
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Picture { get; set; } = null!;

    public int Price { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
