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
		IDataResult<List<CaseType>> GetAll();
		IDataResult<CaseType> GetById(int davaturId);
		IResult Add(CaseType davaTur);
		IResult Update(CaseType davaTur);
	}
}
