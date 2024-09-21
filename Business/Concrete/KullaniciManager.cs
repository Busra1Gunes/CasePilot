using AutoMapper;
using Business.Abstract;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullanici _kullaniciDal;
        readonly IMapper _mapper;

        public KullaniciManager(IKullanici kullaniciDal, IMapper mapper)
        {
            _kullaniciDal = kullaniciDal;
            _mapper = mapper;
        }
        // [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
        [ValidationAspect(typeof(KullaniciValidator))]
        public IResult Add(KullaniciDto kullanici)
        {
            Kullanici kullanici1 = new()
            {
                Adi = kullanici.Adi,
                Soyadi = kullanici.Soyadi,
                IlId = kullanici.IlId,
                IlceId = kullanici.IlceId,
                KullaniciAdi = kullanici.KullaniciAdi,
                Sifre = kullanici.Sifre,
                EklenmeTarihi=DateTime.Now


            };

            _kullaniciDal.Add(kullanici1);
            return new SuccessResult("Kullanıcı eklendi");

        }
        public IDataResult<Kullanici> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetAll()
        {
            var list = _kullaniciDal.GetAll(k=>k.Id>0);
            return _mapper.Map<List<KullaniciListeDto>>(list);
            
        }
    }
}
