using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int DetailsId { get; set; }

    public virtual UserDetail Details { get; set; } = null!;
}
