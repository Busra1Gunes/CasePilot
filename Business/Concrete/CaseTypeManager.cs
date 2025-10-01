using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
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
        public CaseTypeManager(ICaseTypeDal caseTypeDal ,IMapper mapper, IUnitOfWork unitOfWork)
        {
            _caseTypeDal = caseTypeDal;
			_mapper = mapper; 
			_unitOfWork = unitOfWork;
        }
        public async Task<IResult> Add(CaseTypeAddDto caseTypedto)
        {
            var casetype = _mapper.Map<CaseType>(caseTypedto);
            _caseTypeDal.AddAsync(casetype); 
			_unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(casetype.ID, CommonMessages.EntityAdded);
        }

		public async Task<IDataResult<List<CaseType>>> GetAll()
		{
		   List<CaseType> casetypeList= _caseTypeDal.GetAllQueryable().ToList();
			return new SuccessDataResult<List<CaseType>>(casetypeList);
		}

		public async Task<IDataResult<CaseType>> Get(int casetypeID)
		{
			CaseType casetype= _caseTypeDal.GetByIdAsync(casetypeID).Result;
			return new SuccessDataResult<CaseType>(casetype);
		}

		public async Task<IResult> Update(CaseType caseType)
		{
			throw new NotImplementedException();
		}
	}
}
