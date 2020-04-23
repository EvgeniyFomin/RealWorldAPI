namespace RealWorldAPI.Models.ViewModels
{
    public class CatchViewModel : BaseViewModel
    {
        public string Fish { get; set; }
        public TackleViewModel Tackle { get; set; }
        public int TackleId { get; set; }
    }
}
