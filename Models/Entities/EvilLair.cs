namespace OverlordAPI.Models.Entities
{
    public class EvilLair
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        //Navigation properties
        public ICollection<Minion> Minions { get; set; } = new List<Minion>();
    }
}
