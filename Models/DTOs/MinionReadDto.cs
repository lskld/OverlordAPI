namespace OverlordAPI.Models.DTOs
{
    public class MinionReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // Här kan vi skicka en sträng istället för enum-siffran
        public string LairName { get; set; } = string.Empty;
    }
}
