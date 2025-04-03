using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities.Dto.KullaniciDto.KullaniciDto;
using System.Security.Cryptography;
using Entities.Dto;

namespace Business.Concrete
{
	public class DosyaManager : IDosyaService
	{

		IDosyaDal _dosyaDal;
		readonly IMapper _mapper;
        public DosyaManager(IDosyaDal dosyaDal ,IMapper mapper)
        {
            _dosyaDal = dosyaDal;
			_mapper=mapper;
        }
        public IResult Add(DosyaKayitDto dosya)
		{

			var dosyakayit=_mapper.Map<DosyaKayitDto, Dosya>(dosya); 

			if (_dosyaDal.Where(k => k.Tc == dosya.Tc).Any())
                return new ErrorResult("Bu tc daha önce kullanılmış!");
            dosyakayit.AcilisTarihi=DateTime.Now;
			dosyakayit.DosyaDurum = 0;

			var sonuc=_dosyaDal.AddAsync(dosyakayit);
			return new SuccessResult("Dosya Kaydedildi");
		}

		public IDataResult<List<DosyaDetayDto>> GetAll()
        {           
            var liste = _dosyaDal.GetAll()
					.Include(d => d.DavaTur)
					.Include(b => b.BasvuruTur)
					.Include(i => i.Il)
					.Include(c => c.Ilce).ToList();
           var list= _mapper.Map<List< DosyaDetayDto>>(liste);
            return new SuccessDataResult<List<DosyaDetayDto>>(list);
		}

		public IDataResult<List<DosyaDetayDto>> GetAllByDavaTurId(int id)
		{
			var liste = _dosyaDal.GetAll()
				.Include(d => d.DavaTur)
				.Include(b => b.BasvuruTur)
				.Include(i => i.Il)
				.Include(c => c.Ilce).Where(s=>s.davaturId.Equals(id)).ToList();
			
			return new SuccessDataResult<List<DosyaDetayDto>>(_mapper.Map<List<DosyaDetayDto>>(liste));
		}

		public IDataResult<DosyaDetayDto> GetById(int dosyaId)
		{

			var dosya = _dosyaDal.Where(k => k.Id == dosyaId )
				.Include(d => d.DavaTur)
				.Include(b => b.BasvuruTur)
				.Include(i => i.Il)
				.Include(i=>i.DosyaPaylar).ThenInclude(z=>z.Kullanici)
				.Include(i=>i.DosyaDavalilar).ThenInclude(d=>d.Davali)
				.Include(c => c.Ilce).SingleOrDefault();

			if (dosya == null)
			{
				return new ErrorDataResult<DosyaDetayDto>("Dosya bulunamadı");
			}

			var liste = _mapper.Map<DosyaDetayDto>(dosya);
			return new SuccessDataResult<DosyaDetayDto>(liste, "Dosya Listelendi");
		}

		public IResult Update(DosyaGuncelleDto dosya)
        {
            Dosya? mevcutDosya = _dosyaDal.Where(d => d.Id == dosya.Id).SingleOrDefault();

            if (mevcutDosya == null)
                return new ErrorResult("Böyle bir dosya bulunamadı!");

            if (_dosyaDal.Where(k => k.Tc == dosya.Tc).Any())
                return new ErrorResult("Bu tc daha önce kullanılmış!");
            _mapper.Map(dosya, mevcutDosya);
            mevcutDosya.GuncellenmeTarihi = DateTime.Now;
             _dosyaDal.Update(mevcutDosya);

			return new SuccessResult("Dosya Güncellendi");	
		}
	}
}
