
namespace RealWorldAPI.Models.Fishing
{
    public class Tackle : Base
    {
        public Lure Lure { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
