using AutoMapper;
using Core;

using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
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
        .ForMember(dest => dest.DosyaPays, opt => opt.MapFrom(x => x.DosyaPaylar)) // Güncellendi
        .ForMember(dest => dest.DosyaDavalis, opt => opt.MapFrom(x => x.DosyaDavalilar))
        .ForMember(dest => dest.BasvuruTur, opt => opt.MapFrom(x => x.BasvuruTur.Adi))
        .ReverseMap();


            CreateMap<Dosya, DosyaGuncelleDto>().ReverseMap();
            CreateMap<DosyaEvrak, DosyaEvrakEkleDto>()
                .ReverseMap();

            CreateMap<DosyaDavali, DosyaDavaliEkleDto>().ReverseMap();

            CreateMap<DosyaPay, DosyaPayListDto>()
                .ForMember(dest => dest.PaySahibi, opt => opt.MapFrom(x => x.Kullanici.Adi + " " + x.Kullanici.Soyadi))
                .ReverseMap();


            CreateMap<DosyaDavali, DosyaDavaliListDto>()
                .ForMember(dest => dest.DavaliAdi, opt => opt.MapFrom(x => x.Davali.DavaliAdi))
                .ReverseMap();

            CreateMap<HesapHareket, HesapHareketEkleDto>().ReverseMap();

            CreateMap<HesapHareket, HesapHareketListDto>()
        .ForMember(dest => dest.Gonderen, opt => opt.MapFrom(x => x.Kullanici1.Adi))
        .ForMember(dest => dest.Alici, opt => opt.MapFrom(x => x.Kullanici2.Adi))
        .ForMember(dest => dest.Dosya, opt => opt.MapFrom(x => x.Dosya.Adi))
        .ReverseMap();

            CreateMap<Kullanici, KullaniciKayitDto>().ReverseMap();
            CreateMap<Kullanici, KullaniciLoginDto>().ReverseMap();
        }
    }
}
