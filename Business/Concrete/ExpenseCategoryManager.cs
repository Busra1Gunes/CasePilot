using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Concrete
{
    public class ExpenseCategoryManager : IExpenseCategoryService
    {
        private readonly IExpenseCategoryDal _categoryDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ExpenseCategoryManager(IExpenseCategoryDal categoryDal, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<List<ExpenseCategoryListDto>>> GetAll()
        {
            var categories = _categoryDal.GetAllQueryable().ToList();
            var dto = _mapper.Map<List<ExpenseCategoryListDto>>(categories);
            return new SuccessDataResult<List<ExpenseCategoryListDto>>(dto);
        }

        public async Task<IResult> Add(ExpenseCategoryAddDto categoryDto)
        {
            var category = _mapper.Map<ExpenseCategory>(categoryDto);
            await _categoryDal.AddAsync(category);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gider kategorisi eklendi");
        }

        public async Task<IResult> Delete(int id)
        {
            var category = await _categoryDal.GetByIdAsync(id);
            if (category == null)
                return new ErrorResult("Kategori bulunamadı");

            category.Status = false;
            _categoryDal.Update(category);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Kategori silindi");
        }
    }

}
