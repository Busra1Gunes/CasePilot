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
using Serilog;

using Log = Serilog.Log;

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
            // Kullanıcı adı ve şifre açıkça loglanıyor
            Log.Information("Giriş denemesi yapıldı → Kullanıcı Adı: {UserName}", userLoginDto.UserName, userLoginDto.Password);

            User? user = _userService
                .Where(k => k.UserName == userLoginDto.UserName && k.Password == userLoginDto.Password)
                .FirstOrDefault();

            if (user != null)
            {
                Log.Information(" Başarılı giriş → Kullanıcı Adı: {UserName}", user.UserName);

                var tokenResult = await _userService.CreateAccessToken(user);
                if (tokenResult.Success)
                    return new SuccessDataResult<AccessToken>(tokenResult.Data);
            }

            Log.Warning("Hatalı giriş → Kullanıcı Adı: {UserName}", userLoginDto.UserName, userLoginDto.Password);

            return new ErrorDataResult<AccessToken>("Kullanıcı adı veya şifre hatalı");
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
