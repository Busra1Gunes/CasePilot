using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.CourtDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourtService 
    {
        Task<IResult> Add(CourtAddDto court);
        Task<IResult> Update(int courtID, CourtUpdateDto courtUpdate);
        Task<IResult> Delete(int courtID);
        Task<IDataResult<CourtDetailDto>> GetById(int courtID);
        Task<IDataResult<List<CourtListDto>>> GetAllAsync();
        Task<IDataResult<List<CourtListDto>>> GetFilteredAsync(CourtFilterDto filter);
        Task<IDataResult<List<CourtListDto>>> GetByCityId(int cityID);
    }

}
