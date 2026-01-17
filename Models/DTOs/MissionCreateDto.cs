namespace OverlordAPI.Models.DTOs
{
    public class MissionCreateDto
    {
        public string Title { get; set; }
        public int Difficulty { get; set; }
        public bool isCompleted { get; set; }
    }
}
