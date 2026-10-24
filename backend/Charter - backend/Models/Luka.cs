using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Luka
{
    public int Idluke { get; set; }

    public string Nazivluke { get; set; } = null!;

    public string Mjesto { get; set; } = null!;

    public decimal Latituda { get; set; }

    public decimal Longituda { get; set; }

    public virtual ICollection<Plovilo> Plovilos { get; set; } = new List<Plovilo>();

    public virtual ICollection<Rezervacija> Rezervacijas { get; set; } = new List<Rezervacija>();
}
