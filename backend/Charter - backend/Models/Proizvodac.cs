using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Proizvodac
{
    public int Idproizvodaca { get; set; }

    public string Nazivproizvodaca { get; set; } = null!;

    public virtual ICollection<Plovilo> Plovila { get; set; } = new List<Plovilo>();
}
