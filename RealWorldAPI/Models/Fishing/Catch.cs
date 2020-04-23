namespace RealWorldAPI.Models.Fishing
{
    public class Catch : Base
    {
        public string Fish { get; set; }
        public Tackle Tackle { get; set; }
        public int TackleId { get; set; }
    }
}
