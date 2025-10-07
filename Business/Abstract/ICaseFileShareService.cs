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
        Task<IDataResult<CaseFileShareListDto>> GetAll();
        Task<IDataResult<CaseFileShareListDto>> GetAllByCaseFileID(int caseFileID);
        Task<IDataResult<CaseFileShareListDto>> GetAllByUserID(int userID);

        Task<IDataResult<CaseFileShareDto>> Get(int shareID);
        Task<IResult> Add(CaseFileShareAddDto caseFileShareAddDto);
        Task<IResult> Update(CaseFileShareAddDto caseFileShare);
        Task<IResult> DeleteCaseFileShareAsync(int id);
    }
}
