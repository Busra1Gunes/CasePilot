using Core.Utilities.Results;
using Entities.Dto;

namespace Business.Abstract
{
    public interface IExpenseCategoryService
    {
        Task<IDataResult<List<ExpenseCategoryListDto>>> GetAll();
        Task<IResult> Add(ExpenseCategoryAddDto categoryDto);
        Task<IResult> Delete(int id);
    }
}
