using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dto.ListDto;
using Entities.Dto.AddDto;

namespace Business.Abstract
{
    public interface ICaseFileDefendantService
    {
        IDataResult<List<CaseFileDefendant>> GetAll();
        /// <summary>
        /// Dosyanın davalilarini listeler
        /// </summary>
        /// <param name="caseFileID"></param>
        /// <returns></returns>
        IDataResult<List<CaseFileDefendant>> GetAllByCaseFileId(int caseFileID);

        IDataResult<CaseFileDefendant> GetById(int caseFileDefendantID);
        /// <summary>
        /// Dosyaya davali ekler
        /// </summary>
        /// <param name="davali"></param>
        /// <returns></returns>
        IResult Add(CaseFileDefendantAddDto caseFileDefendant);
        /// <summary>
        /// Dosyanin davalısını günceller
        /// </summary>
        /// <param name="davali"></param>
        /// <returns></returns>
        IResult Update(CaseFileDefendant caseFileDefendant);



    }
}
