using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.ExpenseDto;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        private readonly IExpenseDal _expenseDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ExpenseManager(IExpenseDal expenseDal, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _expenseDal = expenseDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<List<ExpenseListDto>>> GetAll()
        {
            var expenses = _expenseDal
                .GetAllQueryable()
                .Include(x => x.User)
                .Include(x => x.CaseFile)
                .Include(x => x.Category)
                .OrderByDescending(x => x.ExpenseDate)
                .ToList();

            var dto = _mapper.Map<List<ExpenseListDto>>(expenses);
            return new SuccessDataResult<List<ExpenseListDto>>(dto);
        }

        public async Task<IDataResult<ExpenseDetailDto>> GetById(int id)
        {
            var expense = await _expenseDal
                .Where(x => x.ID == id)
                .Include(x => x.User)
                .Include(x => x.CaseFile)
                .Include(x => x.Category)
                .FirstOrDefaultAsync();

            if (expense == null)
                return new ErrorDataResult<ExpenseDetailDto>("Gider kaydı bulunamadı");

            var dto = _mapper.Map<ExpenseDetailDto>(expense);
            return new SuccessDataResult<ExpenseDetailDto>(dto);
        }

        public async Task<IDataResult<List<ExpenseListDto>>> GetByUserId(int userId)
        {
            var expenses = _expenseDal
                .Where(x => x.UserID == userId)
                .Include(x => x.User)
                .Include(x => x.CaseFile)
                .Include(x => x.Category)
                .OrderByDescending(x => x.ExpenseDate)
                .ToList();

            var dto = _mapper.Map<List<ExpenseListDto>>(expenses);
            return new SuccessDataResult<List<ExpenseListDto>>(dto);
        }

        public async Task<IDataResult<List<ExpenseListDto>>> GetByCaseFileId(int caseFileId)
        {
            var expenses = _expenseDal
                .Where(x => x.CaseFileID == caseFileId)
                .Include(x => x.User)
                .Include(x => x.CaseFile)
                .Include(x => x.Category)
                .OrderByDescending(x => x.ExpenseDate)
                .ToList();

            var dto = _mapper.Map<List<ExpenseListDto>>(expenses);
            return new SuccessDataResult<List<ExpenseListDto>>(dto);
        }

        public async Task<IDataResult<List<ExpenseListDto>>> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            var expenses = _expenseDal
                .Where(x => x.ExpenseDate >= startDate && x.ExpenseDate <= endDate)
                .Include(x => x.User)
                .Include(x => x.CaseFile)
                .Include(x => x.Category)
                .OrderByDescending(x => x.ExpenseDate)
                .ToList();

            var dto = _mapper.Map<List<ExpenseListDto>>(expenses);
            return new SuccessDataResult<List<ExpenseListDto>>(dto);
        }

        public async Task<IDataResult<List<ExpenseListDto>>> GetByPaymentStatus(int paymentStatus)
        {
            var expenses = _expenseDal
                .Where(x => x.PaymentStatus == paymentStatus)
                .Include(x => x.User)
                .Include(x => x.CaseFile)
                .Include(x => x.Category)
                .OrderByDescending(x => x.ExpenseDate)
                .ToList();

            var dto = _mapper.Map<List<ExpenseListDto>>(expenses);
            return new SuccessDataResult<List<ExpenseListDto>>(dto);
        }

        public async Task<IResult> Add(ExpenseAddDto expenseDto)
        {
            var expense = _mapper.Map<Expense>(expenseDto);
            await _expenseDal.AddAsync(expense);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gider kaydı eklendi");
        }

        public async Task<IResult> Update(ExpenseUpdateDto expenseDto)
        {
            var expense = await _expenseDal.GetByIdAsync(expenseDto.ID);
            if (expense == null)
                return new ErrorResult("Gider kaydı bulunamadı");

            _mapper.Map(expenseDto, expense);
            _expenseDal.Update(expense);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gider kaydı güncellendi");
        }

        public async Task<IResult> Delete(int id)
        {
            var expense = await _expenseDal.GetByIdAsync(id);
            if (expense == null)
                return new ErrorResult("Gider kaydı bulunamadı");

            expense.Status = false;
            _expenseDal.Update(expense);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gider kaydı silindi");
        }
    }
}
