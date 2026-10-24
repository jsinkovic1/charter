using Charter___backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using System;

namespace Charter___backend.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PloviloController : ControllerBase
	{
		private readonly AppDbContext ctx;

		public PloviloController(AppDbContext ctx)
		{
			this.ctx = ctx;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var plovila = await ctx.Plovila
				.Include(p => p.Proizvodac)
				.Select(p => new
				{
					name = p.Nazivplovila,
                    year = p.Godinaproizvodnje,
					manufacturer = p.Proizvodac.Nazivproizvodaca,
                })
				.ToListAsync();

			return Ok(plovila);
		}

		[HttpGet("id")]
		public async Task<IActionResult> Get(int id)
		{
			var plovilo = await ctx.Plovila
				.Include(p => p.Proizvodac)
				.Include(p => p.Tipplovila)
				.Include(p => p.Luka)
				.Where(p => p.Idplovila == id)
				.FirstOrDefaultAsync();

			return Ok(plovilo);
        }
	}
}

