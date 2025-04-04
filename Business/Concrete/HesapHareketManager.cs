using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.DosyaDto;
using Entities.Enums;
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
        public IResult Add(HesapHareketEkleDto hareket)
        {
           

            var hesapHareket = _mapper.Map<HesapHareketEkleDto, HesapHareket>(hareket);
            if (hesapHareket.HareketTuru == HareketTuru.DosyaMasrafi)
            {
                if (hesapHareket.DosyaId != null) return new ErrorResult("DosyaId alanı hareket türü dosyaMasrafı ise null gönderilemez");
                hesapHareket.HareketDurumu = HareketDurumu.Alacak;
            }
            if (hesapHareket.HareketTuru == HareketTuru.Kira || hareket.HareketTuru == HareketTuru.Fatura || hareket.HareketTuru == HareketTuru.Maas ||
                hesapHareket.HareketTuru == HareketTuru.Transfer)
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

        public IDataResult<List<HesapHareket>> GetAllByDosyaId(int dosyaID)
        {
            throw new NotImplementedException();
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
