using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.EvrakDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDosyaDavaliService
    {
        IDataResult<List<DosyaDavali>> GetAll();
        /// <summary>
        /// Dosyanın davalilarini listeler
        /// </summary>
        /// <param name="dosyaID"></param>
        /// <returns></returns>
        IDataResult<List<DosyaDavali>> GetAllByDosyaId(int dosyaID);

        IDataResult<DosyaDavali> GetById(int davaliId);
        /// <summary>
        /// Dosyaya davali ekler
        /// </summary>
        /// <param name="davali"></param>
        /// <returns></returns>
        IResult Add(DosyaDavaliEkleDto davali);
        /// <summary>
        /// Dosyanin davalısını günceller
        /// </summary>
        /// <param name="davali"></param>
        /// <returns></returns>
        IResult Update(DosyaDavali davali);
    }
}
