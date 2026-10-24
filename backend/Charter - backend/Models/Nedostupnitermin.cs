using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Nedostupnitermin
{
    public int Idtermina { get; set; }

    public string Opis { get; set; } = null!;

    public virtual Termin IdterminaNavigation { get; set; } = null!;
}
