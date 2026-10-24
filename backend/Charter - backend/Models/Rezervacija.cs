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

    public virtual Luka Luka { get; set; } = null!;

    public virtual Termin Termin { get; set; } = null!;

    public virtual ICollection<Korisnik> Korisnici { get; set; } = new List<Korisnik>();

    public virtual ICollection<Oprema> Oprema { get; set; } = new List<Oprema>();

    public virtual ICollection<Usluga> Usluge { get; set; } = new List<Usluga>();
}
