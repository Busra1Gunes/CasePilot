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
	public class UserManager :Manager<User>, IUserService
	{
		
		IUserDal _userDal;
		ITokenHelper _tokenHelper;
		readonly IMapper _mapper;

		public UserManager(IUserDal userDal, IMapper mapper,ITokenHelper tokenHelper):base(userDal)
		{

            _userDal = userDal;
			_mapper = mapper;
			_tokenHelper = tokenHelper;
		}
		// [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
		[ValidationAspect(typeof(UserValidator))]
		public IResult Add(UserAddDto user)
		{
			User list = _mapper.Map<UserAddDto, User>(user);
            _userDal.AddAsync(list);
			return new SuccessResult("Kullanıcı eklendi");
		}
		public IDataResult<KullaniciListeDto> GetById(int id)
		{
			var user = _userDal.GetByIdAsync(id);
			var list = _mapper.Map<KullaniciListeDto>(user);
			return new SuccessDataResult<KullaniciListeDto>(list);
		}
		public async Task<object> GetAll()
		{
			var list = _userDal.GetAll()
				.Include(i=>i.City)
				.Include(i => i.District);
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

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
         
            var accessToken = _tokenHelper.CreateToken(user);
            return new SuccessDataResult<AccessToken>(accessToken);
        }
    }
}
