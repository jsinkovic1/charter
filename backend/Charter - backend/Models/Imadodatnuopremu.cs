using Charter___backend.Models;
using System;
public class Imadodatnuopremu
{
	public int idopreme { get; set; }

	public int idtermina { get; set; }

	public Oprema Oprema { get; set; } = null!;

	public Rezervacija Rezervacija { get; set; } = null!;
}
