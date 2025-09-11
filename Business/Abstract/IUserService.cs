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

namespace Business.Abstract
{
    public interface IUserService : IService<User>
    {
        Task<object> GetAll();
        Task<object> GetById(int id);
        Task<IResult> Add(UserAddDto user);
        Task<IResult> DeleteById(int id);
        Task<IResult> UserExists(string email);
        Task<IDataResult<AccessToken>> CreateAccessToken(User user, List<Permissions> permissions);
        Task<IResult> AddFromExcel(IFormFile file);
        Task<IResult> Update(int userID, UserAddDto userAdd);


    }
}
