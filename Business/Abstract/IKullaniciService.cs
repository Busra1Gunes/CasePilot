using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKullaniciService
	{
       Task<object> GetAll();
        IDataResult<KullaniciListeDto> GetById(int id);
        IResult Add(KullaniciKayitDto kullanici);

        IResult DeleteById(int id);

    }
}
