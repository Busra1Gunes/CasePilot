using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public CaseTypeManager(ICaseTypeDal caseTypeDal ,IMapper mapper)
        {
            _caseTypeDal = caseTypeDal;
			_mapper = mapper;	
        }
        public async Task<IResult> Add(CaseType caseType)
		{
            _caseTypeDal.AddAsync(caseType);
            return new SuccessDataResult<int>(caseType.ID, CommonMessages.EntityAdded);
        }

		public async Task<IDataResult<List<CaseType>>> GetAll()
		{
		   List<CaseType> davaTurleri= _caseTypeDal.GetAllQueryable().ToList();
			return new SuccessDataResult<List<CaseType>>(davaTurleri);
		}

		public async Task<IDataResult<CaseType>> Get(int davaturId)
		{
			CaseType davaTur= _caseTypeDal.GetByIdAsync(davaturId).Result;
			return new SuccessDataResult<CaseType>(davaTur);
		}

		public async Task<IResult> Update(CaseType davaTur)
		{
			throw new NotImplementedException();
		}
	}
}
