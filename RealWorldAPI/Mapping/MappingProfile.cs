using AutoMapper;
using RealWorldAPI.Models.Fishing;
using RealWorldAPI.Models.ViewModels;

namespace RealWorldAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lure, LureViewModel>();
            CreateMap<Fishing, FishingViewModel>();
            CreateMap<Catch, CatchViewModel>();
            CreateMap<Tackle, TackleViewModel>();
        }
    }
}
