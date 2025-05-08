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
	public interface ICaseFileService
	{
		IDataResult<List<CaseFileDetailDto>> GetAll();
		IDataResult<List<CaseFileDetailDto>> GetAllByCaseTypeId(int id);

		IDataResult<CaseFileDetailDto> GetById(int dosyaId);
		Task<IResult> Add(CaseFileAddDto dosya);
		Task<IResult> Update(CaseFileUpdateDto dosya);
	//	IResult AddTransactional(Dosya dosya);

	}
}
