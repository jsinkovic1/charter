using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Oprema
{
    public int Idopreme { get; set; }

    public string Nazivopreme { get; set; } = null!;

    public decimal Cijenanajma { get; set; }

    public virtual ICollection<Plovilo> Plovila { get; set; } = new List<Plovilo>();

    public virtual ICollection<Rezervacija> Rezervacije { get; set; } = new List<Rezervacija>();
}
