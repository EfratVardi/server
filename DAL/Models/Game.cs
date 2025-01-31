using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Game
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TypeGameId { get; set; }

    public int DetailsId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int SettingsId { get; set; }

    public int? AudienceId { get; set; }

    public virtual Audience? Audience { get; set; }

    public virtual UserDetail Details { get; set; } = null!;

    public virtual Setting Settings { get; set; } = null!;

    public virtual TypeGame TypeGame { get; set; } = null!;
}
