using Business.Utilities.Security;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<User>> Register(UserAddDto kullaniciKayitDto);
        Task<IDataResult<AccessToken>> Login(UserLoginDto kullaniciLogin);
    }
}
