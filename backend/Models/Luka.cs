using System;
using System.Collections.Generic;

namespace CharterBackend.Models;

public partial class Luka
{
    public int Idluke { get; set; }

    public string Nazivluke { get; set; } = null!;

    public string Mjesto { get; set; } = null!;

    public decimal Latituda { get; set; }

    public decimal Longituda { get; set; }

    public virtual ICollection<Plovilo> Plovila { get; set; } = new List<Plovilo>();

    public virtual ICollection<Rezervacija> Rezervacije { get; set; } = new List<Rezervacija>();
}
