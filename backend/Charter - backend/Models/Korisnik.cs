using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Korisnik
{
    public int Idkorisnika { get; set; }

    public string Username { get; set; } = null!;

    public string Ime { get; set; } = null!;

    public string Prezime { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public DateOnly Datumrodenja { get; set; }

    public bool Aktivan { get; set; }

    public string Uloga { get; set; } = null!;

    public virtual ICollection<Rezervacija> Idterminas { get; set; } = new List<Rezervacija>();
}
