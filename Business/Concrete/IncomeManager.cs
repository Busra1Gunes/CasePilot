using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.IncomeDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IncomeManager : Manager<Income>, IIncomeService
    {
        private readonly IIncomeDal _incomeDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public IncomeManager(IIncomeDal incomeDal, IMapper mapper, IUnitOfWork unitOfWork) : base(incomeDal)
        {
            _incomeDal = incomeDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<List<IncomeListDto>>> GetAll()
        {
            var incomes = _incomeDal
                 .GetAllQueryable()
                 .Include(x => x.User)
                 .Include(x => x.Category)
                 .OrderByDescending(x => x.IncomeDate)
                 .Where(i => i.Status.Equals(true))
                 .ToList();

            var dto = _mapper.Map<List<IncomeListDto>>(incomes);
            return new SuccessDataResult<List<IncomeListDto>>(dto);
        }

        public async Task<IDataResult<IncomeDetailDto>> GetById(int id)
        {
            var income = await _incomeDal
                .Where(x => x.ID == id)
                .Include(x => x.User)
                .Include(x => x.Category)
                .Where(i => i.Status.Equals(true))
                .FirstOrDefaultAsync();

            if (income == null)
                return new ErrorDataResult<IncomeDetailDto>("Gelir kaydı bulunamadı");

            var dto = _mapper.Map<IncomeDetailDto>(income);
            return new SuccessDataResult<IncomeDetailDto>(dto);
        }

        public async Task<IDataResult<List<IncomeListDto>>> GetByUserId(int userId)
        {
            var incomes = _incomeDal
                .Where(x => x.UserID == userId)
                .Include(x => x.User)
                .Include(x => x.Category)
                .Where(i => i.Status.Equals(true))
                .OrderByDescending(x => x.IncomeDate)
                .ToList();

            var dto = _mapper.Map<List<IncomeListDto>>(incomes);
            return new SuccessDataResult<List<IncomeListDto>>(dto);
        }



        public async Task<IDataResult<List<IncomeListDto>>> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            var incomes = _incomeDal
                .Where(x => x.IncomeDate >= startDate && x.IncomeDate <= endDate)
                .Include(x => x.User)
                .Include(x => x.Category)
                .Where(i => i.Status.Equals(true))
                .OrderByDescending(x => x.IncomeDate)
                .ToList();

            var dto = _mapper.Map<List<IncomeListDto>>(incomes);
            return new SuccessDataResult<List<IncomeListDto>>(dto);
        }

        public async Task<IResult> Add(IncomeAddDto incomeDto)
        {
            var income = _mapper.Map<Income>(incomeDto);
            income.Status=true;
            await _incomeDal.AddAsync(income);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gelir kaydı eklendi");
        }

        public async Task<IResult> Update(IncomeUpdateDto incomeDto)
        {
            var income = await _incomeDal.GetByIdAsync(incomeDto.ID);
            if (income == null)
                return new ErrorResult("Gelir kaydı bulunamadı");

            _mapper.Map(incomeDto, income);
            _incomeDal.Update(income);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gelir kaydı güncellendi");
        }

        public async Task<IResult> Delete(int id)
        {
            var income = await _incomeDal.GetByIdAsync(id);
            if (income == null)
                return new ErrorResult("Gelir kaydı bulunamadı");

            income.Status = false;
            _incomeDal.Update(income);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Gelir kaydı silindi");
        }
    }
}
