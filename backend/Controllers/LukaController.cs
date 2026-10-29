using CharterBackend.Data;
using CharterBackend.Dtos;
using CharterBackend.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharterBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LukaController: ControllerBase
    {
        private readonly AppDbContext ctx;
        public LukaController(AppDbContext ctx) 
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHarbors()
        {
            var harbors = ctx.Luke.Select(h => h.ToLukaDTO());
            return Ok(harbors);
        }

        [HttpPost("filtar")]
        public async Task<IActionResult> GelFilteredHarbors([FromBody] LukaFilterDTO lukaFilterDTO)
        {
            var name = lukaFilterDTO.Name;
            var place = lukaFilterDTO.Place;
            var capacity = lukaFilterDTO.Capacity;
            var TimeFrom = lukaFilterDTO.TimeFrom;
            var TimeTo = lukaFilterDTO.TimeTo;

            var harbors = await ctx.Luke.Include(h => h.Plovila).ThenInclude(p => p.Termini)
                                        .Where(h => h.Nazivluke == name && h.Mjesto == place)
                                        .ToListAsync();

            var result = harbors.Select(h =>
            {
                var vessels = h.Plovila
                            .Where(p => p.Kapacitet >= capacity &&
                                    !p.Termini.Any(t =>
                                        t.Vrijemeod < TimeTo &&
                                        t.Vrijemedo > TimeFrom)).ToList();
                return new { Harbor = h, Vessels = vessels };
            }).Where(x => x.Vessels.Any())
            .Select(x => x.Harbor.ToLukaSploviloDTO(x.Vessels))
            .ToList();
            
            return Ok(result);
                                    
        }
    }
}
