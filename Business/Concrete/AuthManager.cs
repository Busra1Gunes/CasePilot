using AutoMapper;
using Business.Abstract;
using Business.Utilities.Security;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;
        readonly IMapper _mapper;
        public AuthManager(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<IDataResult<AccessToken>> Login(UserLoginDto userLoginDto)
        {
            User? user = _userService
                .Where(k => k.UserName.Equals(userLoginDto.UserName) && k.Password.Equals(userLoginDto.Password)).FirstOrDefault();
            
            if (user != null)
            {
              AccessToken token= _userService.CreateAccessToken(user).Result.Data;
                return new SuccessDataResult<AccessToken>(token);
            }
           return new ErrorDataResult<AccessToken>();

          
        }

        public async Task<IDataResult<User>> Register(UserAddDto userAddDto)
        {
            var User = _userService.Where(k => k.UserName.Equals(userAddDto.UserName)).Any();
            if (User)
            {
                return new ErrorDataResult<User>("");
            }
            User user1 = _mapper.Map<User>(userAddDto);
            _userService.AddAsync(user1);
            return new SuccessDataResult<User>(user1);

        }
    }
}
