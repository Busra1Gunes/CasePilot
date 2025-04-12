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
            //if (hesapHareket.HareketTuru == HareketTuru.Kira
            //    || hareket.HareketTuru == HareketTuru.Fatura
            //    || hareket.HareketTuru == HareketTuru.Maas
            //    || hesapHareket.HareketTuru == HareketTuru.Transfer)
            //{
            //    hesapHareket.DosyaId = null;
            //    hesapHareket.HareketDurumu = HareketDurumu.Borc;
            //}
            var sonuc = _hesapHareketDal.AddAsync(hesapHareket);
            return new SuccessResult("Hareket Kaydedildi");
        }

        public IDataResult<List<HesapHareket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<HesapHareketListDto> GetAllByUserID(int userID)
        {
            
                var hareketler = _hesapHareketDal
                    .Where(x => x.BorcluID == userID || x.AlacakId == userID)
                    .Include(a=>a.Kullanici1)
                    .Include(a=>a.Kullanici2)
                    .Include(a=>a.Dosya);
                var hareketDtos = _mapper.Map<List<HesapHareketDto>>(hareketler);

                var bakiyeDto = new HesapBakiyeDto();

                foreach (var h in hareketler)
                {
                    // Ödeme yapılmış mı kontrolü
                    bool odendi = h.OdemeDurumu == true;

                    // Kullanıcı borçlu taraf mı?
                    if (h.BorcluID == userID)
                    {
                        if (odendi)
                            bakiyeDto.ToplamBorc += h.Tutar;
                        else
                            bakiyeDto.BekleyenBorc += h.Tutar;
                    }

                    // Kullanıcı alacaklı taraf mı?
                    if (h.AlacakId == userID)
                    {
                        if (odendi)
                            bakiyeDto.ToplamAlacak += h.Tutar;
                        else
                            bakiyeDto.BekleyenAlacak += h.Tutar;
                    }
                }

                // Net bakiye: alınan - gönderilen
                bakiyeDto.NetBakiye = (bakiyeDto.ToplamAlacak  -
                                      bakiyeDto.ToplamBorc );
                HesapHareketListDto hesapHareketListDto = new HesapHareketListDto
                {
                    Bakiye = bakiyeDto,
                    Hareketler = hareketDtos
                };


                return new SuccessDataResult<HesapHareketListDto>(hesapHareketListDto);


            
            //var harekets = _hesapHareketDal.Where()
            //.Include(d => d.Kullanici1)
            //.Include(b => b.Kullanici2)
            //.Include(i => i.Dosya)
            //.Include(i => i.Dosya).ToList();


            //if (harekets == null)
            //{
            //    return new ErrorDataResult<HesapHareketListDto>("Hareket bulunamadı");
            //}

            //var liste = _mapper.Map<HesapHareketListDto>(harekets);
            //return new SuccessDataResult<HesapHareketListDto>(liste, "Hareket Listelendi");
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
