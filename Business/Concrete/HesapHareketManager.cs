using AutoMapper;
using Business.Abstract;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class HesapHareketManager : IHesapHareketService
    {
        readonly IMapper _mapper;
        readonly IHesapHareketDal _hesapHareketDal;
        public HesapHareketManager(IHesapHareketDal hesapHareketDal, IMapper mapper)
        {
            _hesapHareketDal = hesapHareketDal;
            _mapper = mapper;
        }
        [ValidationAspect(typeof(HesapHareketEkleDtoValidator))]
        public IResult Add(HesapHareketEkleDto hareket)
        {         
            var hesapHareket = _mapper.Map<HesapHareketEkleDto, HesapHareket>(hareket);
            if (hesapHareket.HareketTuru == HareketTuru.DosyaMasrafi)
            {              
                hesapHareket.HareketDurumu = HareketDurumu.Alacak;
            }
            if (hesapHareket.HareketTuru == HareketTuru.Kira
                || hareket.HareketTuru == HareketTuru.Fatura
                || hareket.HareketTuru == HareketTuru.Maas
                || hesapHareket.HareketTuru == HareketTuru.Transfer)
            {
                hesapHareket.DosyaId = null;
                hesapHareket.HareketDurumu = HareketDurumu.Borc;
            }
            var sonuc = _hesapHareketDal.AddAsync(hesapHareket);
            return new SuccessResult("Hareket Kaydedildi");
        }

        public IDataResult<List<HesapHareket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<HesapHareketListDto>> GetAllByDosyaId(int dosyaID)
        {
            var harekets = _hesapHareketDal.Where(k => k.DosyaId == dosyaID)
            .Include(d => d.Kullanici1)
            .Include(b => b.Kullanici2)
            .Include(i => i.Dosya)
            .Include(i => i.Dosya).ToList();
          

            if (harekets == null)
            {
                return new ErrorDataResult<List<HesapHareketListDto>>("Hareket bulunamadı");
            }

            var liste = _mapper.Map<List<HesapHareketListDto>>(harekets);
            return new SuccessDataResult<List<HesapHareketListDto>>(liste, "Hareket Listelendi");
        }

        public IDataResult<HesapHareket> GetById(int hareketId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(HesapHareket hareket)
        {
            throw new NotImplementedException();
        }
    }
}
