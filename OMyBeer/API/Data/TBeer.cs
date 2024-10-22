using System;
using System.Collections.Generic;

namespace API.Data;

public partial class TBeer
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Volume { get; set; } = null!;
}
