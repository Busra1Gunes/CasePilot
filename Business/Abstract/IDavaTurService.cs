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
	public interface IDavaTurService
	{
		IDataResult<List<DavaTur>> GetAll();
		IDataResult<DavaTur> GetById(int davaturId);
		IResult Add(DavaTur davaTur);
		IResult Update(DavaTur davaTur);
	}
}
