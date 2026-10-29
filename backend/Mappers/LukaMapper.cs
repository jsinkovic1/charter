using CharterBackend.Dtos;
using CharterBackend.Models;
using System.Runtime.CompilerServices;

namespace CharterBackend.Mappers
{
    public static class LukaMapper
    {
        public static LukaDTO ToLukaDTO(this Luka lukaModel)
        {
            return new LukaDTO
            {
                Idluke = lukaModel.Idluke,
                Latituda = lukaModel.Latituda,
                Longituda = lukaModel.Longituda,
                Mjesto = lukaModel.Mjesto,
                Nazivluke = lukaModel.Nazivluke
            };
        }

        public static LukaSPlovilomDTO ToLukaSploviloDTO(this Luka lukaModel, IEnumerable<Plovilo> vessels)
        {
            return new LukaSPlovilomDTO
            {
                Idluke = lukaModel.Idluke,
                Nazivluke = lukaModel.Mjesto,
                Mjesto = lukaModel.Mjesto,
                Longituda = lukaModel.Longituda,
                Latituda = lukaModel.Latituda,
                IdsPlovila = vessels.Select(p => p.Idplovila).ToList()
            };
        }
    }
}
