using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Concrete
{
    public class IncomeCategoryManager : IIncomeCategoryService
    {
        private readonly IIncomeCategoryDal _categoryDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public IncomeCategoryManager(IIncomeCategoryDal categoryDal, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<List<IncomeCategoryListDto>>> GetAll()
        {
            var categories = _categoryDal.GetAllQueryable().ToList();
            var dto = _mapper.Map<List<IncomeCategoryListDto>>(categories);
            return new SuccessDataResult<List<IncomeCategoryListDto>>(dto);
        }

        public async Task<IResult> Add(IncomeCategoryAddDto categoryDto)
        {
            var category = _mapper.Map<IncomeCategory>(categoryDto);
            await _categoryDal.AddAsync(category);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gelir kategorisi eklendi");
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
