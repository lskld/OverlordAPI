namespace OverlordAPI.Models.DTOs
{
    public class MinionReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; 
        public int EvilLevel { get; set; }
        public string EvilLairName { get; set; } = string.Empty;
    }
}
