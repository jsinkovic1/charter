using Charter___backend.Models;
using System;
public class Imaopremu
{
	public int idplovila { get; set; }

	public int idopreme { get; set; }

	public Oprema Oprema { get; set; } = null!;

	public Plovilo Plovilo { get; set; } = null!;
}
