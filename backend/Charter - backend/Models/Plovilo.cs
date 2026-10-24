using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Plovilo
{
    public int Idplovila { get; set; }

    public string Nazivplovila { get; set; } = null!;

    public int Godinaproizvodnje { get; set; }

    public int Kapacitet { get; set; }

    public int Brojkabina { get; set; }

    public int Brojlezajeva { get; set; }

    public string Model { get; set; } = null!;

    public decimal Dnevnacijenanajma { get; set; }

    public int Idluke { get; set; }

    public int Idtipaplovila { get; set; }

    public int Idproizvodaca { get; set; }

    public virtual ICollection<Fotografija> Fotografije { get; set; } = new List<Fotografija>();

    public virtual Luka IdlukeNavigation { get; set; } = null!;

    public virtual Proizvodac IdproizvodacaNavigation { get; set; } = null!;

    public virtual Tipplovila IdtipaplovilaNavigation { get; set; } = null!;

    public virtual ICollection<Termin> Termini { get; set; } = new List<Termin>();

    public virtual ICollection<Oprema> Idoprema { get; set; } = new List<Oprema>();
}
