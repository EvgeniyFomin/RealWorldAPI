using System.Collections.Generic;

namespace RealWorldAPI.Models.ViewModels
{
    public class FishingViewModel : BaseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public ICollection<CatchViewModel> Catch { get; set; }
        public bool IsLiked { get; set; }
        public bool IsCatch { get; set; }
    }
}
