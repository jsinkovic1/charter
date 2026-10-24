using Charter___backend.Models;
using System;

public class Imadodatneusluge
{
	public int idusluge { get; set; }

	public int idtermina { get; set; }

	public Usluga Usluga { get; set; } = null!;

	public Rezervacija rezervacija { get; set; } = null!;
}
