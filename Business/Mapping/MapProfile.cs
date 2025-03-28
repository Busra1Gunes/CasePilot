using AutoMapper;
using Core;

using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.EvrakDto;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using Microsoft.AspNetCore.Http;

namespace Service.Mapping
{
	public class MapProfile : Profile
	{

		public MapProfile(IHttpContextAccessor httpContextAccessor)
		{
			CreateMap<Kullanici, KullaniciKayitDto>()
				//.ForMember(dest=>dest.Il,opt=>opt.MapFrom(k=>k.Il.Adi))
				//.ForMember(dest=>dest.Ilce,opt=>opt.MapFrom(k=>k.Ilce.IlceAdi))
				.ReverseMap();

			CreateMap<Kullanici, KullaniciListeDto>()
				.ForMember(dest => dest.Il, opt => opt.MapFrom(x => x.Il.Adi))
				.ForMember(dest => dest.Ilce, opt => opt.MapFrom(x => x.Ilce.IlceAdi))
				.ReverseMap();

			CreateMap<Dosya, DosyaKayitDto>().ReverseMap();


			CreateMap<Dosya, DosyaDetayDto>()
			    .ForMember(dest => dest.Il, opt => opt.MapFrom(x => x.Il.Adi))
				.ForMember(dest => dest.Ilce, opt => opt.MapFrom(x => x.Ilce.IlceAdi))
				.ForMember(dest => dest.DavaTur, opt => opt.MapFrom(x => x.DavaTur.Adi))
				.ForMember(dest => dest.BasvuruTur, opt => opt.MapFrom(x => x.BasvuruTur.Adi))
				.ReverseMap();


			CreateMap<Dosya,DosyaGuncelleDto>().ReverseMap();
            CreateMap<DosyaEvrak, DosyaEvrakEkleDto>()
				.ReverseMap();
        }
	}
}
