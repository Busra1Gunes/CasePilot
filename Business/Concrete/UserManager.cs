using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
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
		
		private IUserDal _userDal;
		private  ITokenHelper _tokenHelper;
		private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public UserManager(IUserDal userDal, IMapper mapper,ITokenHelper tokenHelper, IUnitOfWork unitOfWork):base(userDal)
		{

            _userDal = userDal;
			_mapper = mapper;
			_tokenHelper = tokenHelper;
			_unitOfWork = unitOfWork;
		}
       
        [ValidationAspect(typeof(UserValidator))]
		public async Task<IResult> Add(UserAddDto user)
		{
			User list = _mapper.Map<UserAddDto, User>(user);
            _userDal.AddAsync(list);
			_unitOfWork.SaveChangesAsync();
			return new SuccessResult(CommonMessages.EntityAdded);
		}
		public async Task<object> GetById(int id)
		{
			var user = _userDal.Where(u => u.ID.Equals(id))
				.Include(i => i.City)
				.Include(i => i.District).First();
			
			return (_mapper.Map<UserListDto>(user));
		}
		public async Task<object> GetAll()
		{
			var list = _userDal.GetAllQueryable()
				.Include(i=>i.City)
				.Include(i => i.District);
			return _mapper.Map<List<UserListDto>>(list);
		}


		public async Task<IResult> DeleteById(int id)
		{			
			return new SuccessResult(CommonMessages.EntityDeleted);
		}

        public async Task<IResult> UserExists(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
        {
         
            var accessToken = _tokenHelper.CreateToken(user);
            return new SuccessDataResult<AccessToken>(accessToken);
        }
    }
}
