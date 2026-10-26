using System;
using System.Collections.Generic;

namespace CharterBackend.Models;

public partial class Nedostupnitermin
{
    public int Idtermina { get; set; }

    public string Opis { get; set; } = null!;

    public virtual Termin Termin { get; set; } = null!;
}
