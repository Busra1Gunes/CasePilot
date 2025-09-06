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
		Task<IDataResult<List<CaseFileDefendant>>> GetAll();
		Task<IDataResult<List<CaseFileDefendantListDto>>> GetAllByCaseFileId(int caseFileID);
		Task<IDataResult<CaseFileDefendant>> GetById(int caseFileDefendantID);
        Task<IResult> Add(CaseFileDefendantAddDto caseFileDefendant);
		Task<IResult> Update(CaseFileDefendant caseFileDefendant);



	}
}
