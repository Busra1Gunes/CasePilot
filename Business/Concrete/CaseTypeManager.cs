using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Exceptions.CaseFile;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.CaseTypeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CaseTypeManager : ICaseTypeService
    {
        ICaseTypeDal _caseTypeDal;
        readonly IMapper _mapper;
        IUnitOfWork _unitOfWork;
        public CaseTypeManager(ICaseTypeDal caseTypeDal, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _caseTypeDal = caseTypeDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> Add(CaseTypeAddDto caseTypedto)
        {
            var casetype = _mapper.Map<CaseType>(caseTypedto);
            casetype.Status = true;
            await _caseTypeDal.AddAsync(casetype);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(casetype.ID, CommonMessages.EntityAdded);
        }

        public async Task<IDataResult<List<CaseType>>> GetAll()
        {
            List<CaseType> casetypeList = _caseTypeDal.GetAllQueryable(a => a.Status.Equals(true)).ToList();
            return new SuccessDataResult<List<CaseType>>(casetypeList);
        }

        public async Task<IDataResult<CaseType>> Get(int casetypeID)
        {
            CaseType casetype = _caseTypeDal.GetByIdAsync(casetypeID).Result;
            return new SuccessDataResult<CaseType>(casetype);
        }

        public async Task<IResult> Update(CaseType caseType)
        {
            throw new NotImplementedException();
        }
        public async Task<IResult> DeleteCaseTypeAsync(int id)
        {
            CaseType? caseType = _caseTypeDal.Where(d => d.ID == id && d.Status.Equals(true)).SingleOrDefault();

            if (caseType == null)
                throw new InvalidCaseFileException();

            caseType.DeletedDate = DateTime.Now;
            caseType.Status = false;
            _caseTypeDal.Update(caseType);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityUpdated);
        }
    }
}
