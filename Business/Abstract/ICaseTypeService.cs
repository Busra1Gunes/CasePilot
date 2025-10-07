using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.CaseTypeDto;
using Entities.Dto.DosyaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICaseTypeService
	{
		Task<IDataResult<List<CaseType>>> GetAll();
		Task<IDataResult<CaseType>> Get(int caseTypeID);
		Task<IResult> Add(CaseTypeAddDto caseType);
		Task<IResult> Update(CaseType caseType);
		Task<IResult> DeleteCaseTypeAsync(int id);


    }
}
