namespace CharterBackend.Dtos
{
    public class LukaSPlovilomDTO
    {
        public int Idluke { get; set; }

        public string Nazivluke { get; set; } = null!;

        public string Mjesto { get; set; } = null!;

        public decimal Latituda { get; set; }

        public decimal Longituda { get; set; }

        public List<int> IdsPlovila { get; set; } = null!;
    }
}
