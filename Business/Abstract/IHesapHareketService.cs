using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHesapHareketService
    {
        IDataResult<List<HesapHareket>> GetAll();
        IDataResult<HesapHareketListDto> GetAllByUserID(int userID);

        IDataResult<HesapHareket> GetById(int hareketId);
        IResult Add(HesapHareketEkleDto hareket);
        IResult Update(HesapHareket hareket);
    }
}
