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

namespace Business.Abstract
{
    public interface IKullaniciService:IService<Kullanici>
	{
       Task<object> GetAll();
        IDataResult<KullaniciListeDto> GetById(int id);
        IResult Add(KullaniciKayitDto kullanici);


        IResult DeleteById(int id);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Kullanici kullanici);

    }
}
