using OverlordAPI.Enums;

namespace OverlordAPI.Models.DTOs
{
    public class MinionCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public MinionType Type { get; set; }
        public int EvilLevel { get; set; }
        public int EvilLairId { get; set; }
    }
}
