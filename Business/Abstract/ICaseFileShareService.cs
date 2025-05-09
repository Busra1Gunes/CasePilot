using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICaseFileShareService
    {
        IDataResult<CaseFileShareListDto> GetAll();
        IDataResult<CaseFileShareListDto> GetAllByCaseFileID(int caseFileID);

        IDataResult<CaseFileShareDto> GetById(int shareID);
       Task<IResult> Add(CaseFileShareAddDto caseFileShareAddDto);
        IResult Update(CaseFileShareAddDto caseFileShare);
    }
}
