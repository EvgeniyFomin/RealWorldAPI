using System.Collections.Generic;

namespace RealWorldAPI.Models.Fishing
{
    public class Fishing : Base
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public ICollection<Catch> Catch { get; set; }
        public bool IsLiked { get; set; }
        public bool IsCatch { get; set; }
    }
}
