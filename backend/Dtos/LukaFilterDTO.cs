namespace CharterBackend.Dtos
{
    public class LukaFilterDTO
    {
        public string? Name { get; set; } = null;
        public string? Place { get; set; } = null;
        public int? Capacity { get; set; } = null;
        public DateTime? TimeFrom { get; set; } = null;
        public DateTime? TimeTo { get; set; } = null;
    }
}
