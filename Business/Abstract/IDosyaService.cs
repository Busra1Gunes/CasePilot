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
	public interface IDosyaService
	{
		IDataResult<List<DosyaDetayDto>> GetAll();
		IDataResult<List<DosyaDetayDto>> GetAllByDavaTurId(int id);

		IDataResult<DosyaDetayDto> GetById(int dosyaId);
		IResult Add(DosyaKayitDto dosya);
		IResult Update(DosyaGuncelleDto dosya);
	//	IResult AddTransactional(Dosya dosya);

	}
}
