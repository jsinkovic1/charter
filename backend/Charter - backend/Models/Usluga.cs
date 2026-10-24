using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Usluga
{
    public int Idusluge { get; set; }

    public string Nazivusluge { get; set; } = null!;

    public decimal Cijenausluge { get; set; }

    public virtual ICollection<Rezervacija> Idterminas { get; set; } = new List<Rezervacija>();
}
