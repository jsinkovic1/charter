using Charter___backend.Models;
using System;
public class Korisnik_rezervacija
{
	public int idkorisnika { get; set; }

	public int idtermina { get; set; }

	public Korisnik Korisnik { get; set; } = null!;

	public Rezervacija Rezervacija { get; set; } = null!;
}
