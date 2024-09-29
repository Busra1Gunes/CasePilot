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
			dosyakayit.AcilisTarihi=DateTime.Now;
			dosyakayit.DosyaDurum = 0;

			_dosyaDal.Add(dosyakayit);
			return new SuccessResult("Dosya Kaydedildi");
		}

		public IDataResult<List<DosyaDetayDto>> GetAll()
		{
			var liste = _dosyaDal.GetAll(d => d.DosyaDurum.Equals(false))
					.Include(d => d.DavaTur)
					.Include(b => b.BasvuruTur)
					.Include(i => i.Il)
					.Include(c => c.Ilce).ToList();

			return new SuccessDataResult<List<DosyaDetayDto>>(_mapper.Map<List<DosyaDetayDto>>(liste));
		}

		public IDataResult<List<DosyaDetayDto>> GetAllByDavaTurId(int id)
		{
			var liste = _dosyaDal.GetAll(d => d.DosyaDurum.Equals(false) && d.davaturId.Equals(id))
				.Include(d => d.DavaTur)
				.Include(b => b.BasvuruTur)
				.Include(i => i.Il)
				.Include(c => c.Ilce).ToList();

			return new SuccessDataResult<List<DosyaDetayDto>>(_mapper.Map<List<DosyaDetayDto>>(liste));
		}

		public IDataResult<DosyaDetayDto> GetById(int dosyaId)
		{

			var dosya = _dosyaDal.Get(d => d.Id.Equals(dosyaId))
				.Include(d => d.DavaTur)
				.Include(b => b.BasvuruTur)
				.Include(i => i.Il)
				.Include(c => c.Ilce)
				.FirstOrDefault(); // veya First() gibi bir yöntem kullanın

			var liste = _mapper.Map<DosyaDetayDto>(dosya);
			return new SuccessDataResult<DosyaDetayDto>(liste);
		}

		public IResult Update(Dosya dosya)
		{
			_dosyaDal.Update(dosya);
			return new SuccessResult("Dosya Güncellendi");	
		}
	}
}
