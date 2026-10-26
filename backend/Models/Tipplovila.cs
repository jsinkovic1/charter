using System;
using System.Collections.Generic;

namespace CharterBackend.Models;

public partial class Tipplovila
{
    public int Idtipaplovila { get; set; }

    public string Nazivtipaplovila { get; set; } = null!;

    public virtual ICollection<Plovilo> Plovila { get; set; } = new List<Plovilo>();
}
