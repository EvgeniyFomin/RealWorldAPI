
namespace RealWorldAPI.Models.ViewModels
{
    public class TackleViewModel : BaseViewModel
    {
        public LureViewModel Lure { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
