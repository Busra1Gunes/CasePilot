using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.FilterDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICaseFileService:IService<CaseFile>
	{
        Task<IDataResult<List<CaseFileListDto>>> GetAllAsync();
        Task<IDataResult<List<CaseFileListDto>>> GetFilteredAsync(CaseFileFilterDto filterDto);
        Task<object> GetAllByCaseTypeId(int ID);
		Task<IDataResult<CaseFileDetailDto>> GetById(int caseFileID);
		Task<IResult> Add(CaseFileAddDto caseFile);
		Task<IResult> Update(int caseFileID, CaseFileUpdateDto caseFile);
        Task<IResult> Delete(int caseFileID);

    }
}
