using System;
using System.Collections.Generic;

namespace Charter___backend.Models;

public partial class Fotografija
{
    public int Idfotografije { get; set; }

    public string Url { get; set; } = null!;

    public bool Glavnaslika { get; set; }

    public int Idplovila { get; set; }

    public virtual Plovilo Plovilo { get; set; } = null!;
}
