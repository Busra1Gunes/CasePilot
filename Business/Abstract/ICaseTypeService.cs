using Core.Utilities.Results;
using Entities.Concrete;
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
		Task<IDataResult<CaseType>> Get(int davaturId);
		Task<IResult> Add(CaseType davaTur);
		Task<IResult> Update(CaseType davaTur);
	}
}
