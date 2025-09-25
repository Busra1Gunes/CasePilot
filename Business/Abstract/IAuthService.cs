using Business.Utilities.Security;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using Entities.Dto.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {  // Authentication
        Task<IResult> Register(UserRegisterDto userRegisterDto);
        Task<IDataResult<AccessToken>> Login(UserLoginDto userLoginDto);
        Task<IResult> Logout(int userId);

        // Password Reset
        Task<IResult> ForgotPassword(ForgotPasswordDto forgotPasswordDto);
        Task<IResult> ResetPassword(ResetPasswordDto resetPasswordDto);

        // Email Confirmation
        Task<IResult> ConfirmEmail(string email, string token);
        Task<IResult> ResendEmailConfirmation(string email);

        // Utility
        Task<IDataResult<User>> GetUserByEmail(string email);
    }
}
