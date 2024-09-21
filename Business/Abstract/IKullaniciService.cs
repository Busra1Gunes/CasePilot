using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
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
        IDataResult<Kullanici> GetById(int id);
        IResult Add(KullaniciDto kullanici);

    }
}
