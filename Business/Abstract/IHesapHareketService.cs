using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.DosyaDto;
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
        IDataResult<List<HesapHareket>> GetAllByDosyaId(int dosyaID);

        IDataResult<HesapHareket> GetById(int hareketId);
        IResult Add(HesapHareketEkleDto hareket);
        IResult Update(HesapHareket hareket);
    }
}
