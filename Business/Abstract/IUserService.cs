using Core.Utilities.Results;
using Entities.Concrete;
using Core.Utilities.Security;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Utilities.Security;
using Microsoft.AspNetCore.Http;
using Entities.Dto.DosyaDto;
using Entities.Dto.UserDto;

namespace Business.Abstract
{
    public interface IUserService : IService<User>
    {
        // CRUD Operations
        Task<IResult> Add(UserAddDto user);
        Task<IDataResult<UserGetDto>> GetById(int id);
        Task<IDataResult<List<UserListDto>>> GetAll();
        Task<IResult> Update(int userID, UserUpdateDto userUpdateDto);
        Task<IResult> UpdateProfile(int userID, UserProfileUpdateDto profileDto);
        Task<IResult> DeleteById(int id);

        // Authentication
        Task<IResult> UserExists(string email);
        Task<User> ValidateUser(string email, string password);
        Task<IDataResult<AccessToken>> CreateAccessToken(User user, List<Permissions> permissions);

        // Password Operations
        Task<IResult> ChangePassword(int userID, ChangePasswordDto changePasswordDto);
        Task<IResult> GeneratePasswordResetToken(string email);
        Task<IResult> ResetPasswordWithToken(ResetPasswordDto resetPasswordDto);

        // Excel Operations
        Task<IResult> AddFromExcel(IFormFile file);

        // Search and Filter
        Task<IDataResult<List<UserListDto>>> SearchUsers(string searchTerm, int? roleId = null, int? cityId = null);
        Task<IDataResult<List<UserListDto>>> GetUsersPaginated(int page = 1, int pageSize = 10);


    }
}
