using Core.Utilities.Results;
using Entities.Dto;

namespace Business.Abstract
{
    public interface IIncomeCategoryService
    {
        Task<IDataResult<List<IncomeCategoryListDto>>> GetAll();
        Task<IResult> Add(IncomeCategoryAddDto categoryDto);
        Task<IResult> Delete(int id);
    }
}
