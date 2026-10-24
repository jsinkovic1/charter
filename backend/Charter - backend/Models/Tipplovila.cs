using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Tipplovila
{
    public int Idtipaplovila { get; set; }

    public string Nazivtipaplovila { get; set; } = null!;

    public virtual ICollection<Plovilo> Plovilos { get; set; } = new List<Plovilo>();
}
