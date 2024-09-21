using AutoMapper;
using Core;

using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Http;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile(IHttpContextAccessor httpContextAccessor)
        {
            CreateMap<Kullanici, KullaniciDto>().ReverseMap();
            CreateMap<Kullanici, KullaniciListeDto>()
                .ForMember(dest => dest.Il, opt => opt.MapFrom(x => x.Il.Adi))
                .ForMember(dest => dest.Ilce, opt => opt.MapFrom(x => x.Ilce.IlceAdi))
                .ReverseMap();

        }
    }
}
