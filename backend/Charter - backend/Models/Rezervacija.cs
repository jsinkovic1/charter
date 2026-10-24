using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Rezervacija
{
    public int Idtermina { get; set; }

    public decimal Iznos { get; set; }

    public bool Poslanaobavijest { get; set; }

    public int Brojosoba { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly Datumkreiranja { get; set; }

    public int Idluke { get; set; }

    public virtual Luka IdlukeNavigation { get; set; } = null!;

    public virtual Termin IdterminaNavigation { get; set; } = null!;

    public virtual ICollection<Korisnik> Idkorisnikas { get; set; } = new List<Korisnik>();

    public virtual ICollection<Oprema> Idopremes { get; set; } = new List<Oprema>();

    public virtual ICollection<Usluga> Idusluges { get; set; } = new List<Usluga>();
}
