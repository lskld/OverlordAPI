using System.ComponentModel.DataAnnotations;

namespace OverlordAPI.Models.DTOs
{
    public class MissionReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Difficulty { get; set; }
        public bool isCompleted { get; set; }
    }
}
