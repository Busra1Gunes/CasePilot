using Business.Abstract;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        readonly ITokenService _tokenService;
        public AuthManager(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public async Task<UserLoginResponseDto> LoginUserAsync(UserLoginRequestDto userLoginRequestDto)
        {
            UserLoginResponseDto response = new();

            if (string.IsNullOrEmpty(userLoginRequestDto.UserName) || string.IsNullOrEmpty(userLoginRequestDto.Password))
            {
                throw new ArgumentNullException(nameof(userLoginRequestDto));
            }

            if (userLoginRequestDto.UserName == "busra" && userLoginRequestDto.Password == "123456")
            {
                var generatedTokenInformation = await _tokenService.GenerateToken(new GenerateTokenRequestDto { Username = userLoginRequestDto.UserName });

                response.AuthenticateResult = true;
                response.AuthToken = generatedTokenInformation.Token;
                response.AccessTokenExpireDate = generatedTokenInformation.TokenExpireDate;
            }

            return response;
        }
    }
}
