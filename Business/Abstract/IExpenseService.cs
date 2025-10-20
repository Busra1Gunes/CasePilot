using Core.Utilities.Results;
using Entities.Dto.ExpenseDto;

namespace Business.Abstract
{
    public interface IExpenseService
    {
        Task<IDataResult<List<ExpenseListDto>>> GetAll();
        Task<IDataResult<ExpenseDetailDto>> GetById(int id);
        Task<IDataResult<List<ExpenseListDto>>> GetByUserId(int userId);
        Task<IDataResult<List<ExpenseListDto>>> GetByDateRange(DateTime startDate, DateTime endDate);
        Task<IDataResult<List<ExpenseListDto>>> GetByPaymentStatus(int paymentStatus);
        Task<IResult> Add(ExpenseAddDto expenseDto);
        Task<IResult> Update(ExpenseUpdateDto expenseDto);
        Task<IResult> Delete(int id);
    }
}
