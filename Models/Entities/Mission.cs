using System.ComponentModel.DataAnnotations;

namespace OverlordAPI.Models.Entities
{
    public class Mission
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [Range(1, 10, ErrorMessage = "Difficulty must be between 1 and 10")]
        public int Difficulty { get; set; }
        public bool isCompleted { get; set; }

        //Navigation properties
        public ICollection<Minion> Minions { get; set; } = new List<Minion>();
    }
}
