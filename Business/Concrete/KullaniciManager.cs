using AutoMapper;
using Business.Abstract;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Business.Utilities.Security;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Messages;
using Core.Utilities.Results;
using Core.Utilities.Security;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Concrete
{
	public class KullaniciManager :Manager<Kullanici>, IKullaniciService
	{
		
		IKullaniciDal _kullaniciDal;
		ITokenHelper _tokenHelper;
		readonly IMapper _mapper;

		public KullaniciManager(IKullaniciDal kullaniciDal, IMapper mapper,ITokenHelper tokenHelper):base(kullaniciDal)
		{

			_kullaniciDal = kullaniciDal;
			_mapper = mapper;
			_tokenHelper = tokenHelper;
		}
		// [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
		[ValidationAspect(typeof(KullaniciValidator))]
		public IResult Add(KullaniciKayitDto kullanici)
		{
			Kullanici liste = _mapper.Map<KullaniciKayitDto, Kullanici>(kullanici);
			_kullaniciDal.AddAsync(liste);
			return new SuccessResult("Kullanıcı eklendi");
		}
		public IDataResult<KullaniciListeDto> GetById(int id)
		{
			var kullanici = _kullaniciDal.GetByIdAsync(id);
			var liste = _mapper.Map<KullaniciListeDto>(kullanici);
			return new SuccessDataResult<KullaniciListeDto>(liste);
		}
		public async Task<object> GetAll()
		{
			var list = _kullaniciDal.GetAll()
				.Include(i=>i.Il)
				.Include(i => i.Ilce);
			return _mapper.Map<List<KullaniciListeDto>>(list);
		}


		public IResult DeleteById(int id)
		{
			//var kullanici = _kullaniciDal.GetByIdAsync(id);
			//_kullaniciDal.de(kullanici);
			return new SuccessResult("Kullanıcı Silindi");
		}

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(Kullanici kullanici)
        {
         
            var accessToken = _tokenHelper.CreateToken(kullanici);
            return new SuccessDataResult<AccessToken>(accessToken);
        }
    }
}
