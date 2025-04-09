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
        IDataResult<Kullanici> Register(KullaniciKayitDto kullaniciKayitDto);
        IDataResult<AccessToken> Login(KullaniciLoginDto kullaniciLogin);
    }
}
