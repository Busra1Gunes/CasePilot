using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.IncomeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIncomeService : IService<Income>
    {
        Task<IDataResult<List<IncomeListDto>>> GetAll();
        Task<IDataResult<IncomeDetailDto>> GetById(int id);
        Task<IDataResult<List<IncomeListDto>>> GetByUserId(int userId);
        Task<IDataResult<List<IncomeListDto>>> GetByDateRange(DateTime startDate, DateTime endDate);
        Task<IResult> Add(IncomeAddDto incomeDto);
        Task<IResult> Update(IncomeUpdateDto incomeDto);
        Task<IResult> Delete(int id);
    }
}
