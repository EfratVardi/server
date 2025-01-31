using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Setting
{
    public int Id { get; set; }

    public string Background { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Music { get; set; } = null!;

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
