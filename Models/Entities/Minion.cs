using OverlordAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace OverlordAPI.Models.Entities
{
    public class Minion
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public MinionType Type { get; set; } = MinionType.Apprentice;

        [Range(1, 10, ErrorMessage = "Evil level must be between 1 and 10")]
        public int EvilLevel { get; set; }

        // Foreign Keys
        public int EvilLairId { get; set; }

        // Navigation Properties
        public EvilLair EvilLair { get; set; } = null!;
        public ICollection<Mission> Missions { get; set; } = new List<Mission>();
    }
}
