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
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;
        IRolePermissionService _rolePermissionService;
        readonly IMapper _mapper;
        public AuthManager(IUserService userService, IMapper mapper,  IRolePermissionService rolePermissionService)
        {
            _userService = userService;
            _mapper = mapper;
            _rolePermissionService = rolePermissionService;
        }

        public async Task<IDataResult<AccessToken>> Login(UserLoginDto userLoginDto)
        {
            // Kullanıcı adı ve şifre açıkça loglanıyor
            Log.Information("Giriş denemesi yapıldı → Kullanıcı Adı: {UserName}", userLoginDto.UserName, userLoginDto.Password);

            var user = _userService
                       .Where(u => u.UserName == userLoginDto.UserName && u.Password == userLoginDto.Password)
                     
                       .FirstOrDefault();

			if (user != null)
			{
				Log.Information("Başarılı giriş → Kullanıcı Adı: {UserName}", user.UserName);

				var permissions = await _rolePermissionService.GetPermissionsByRoleAsync(user.RoleID.Value);

				var tokenResult =await _userService.CreateAccessToken(user, permissions);

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
