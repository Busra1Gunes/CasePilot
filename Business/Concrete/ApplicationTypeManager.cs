using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.ApplicationTypeDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicationTypeManager : IApplicationTypeService
    {
        IApplicationTypeDal _applicationTypeDal;
        IMapper _mapper;
        IUnitOfWork _unitOfWork;
        public ApplicationTypeManager(IApplicationTypeDal applicationTypeDal, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _applicationTypeDal = applicationTypeDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> Add(ApplicationTypeDto applicationType)
        {
            var applicationType1 = _mapper.Map<ApplicationType>(applicationType);
            await _applicationTypeDal.AddAsync(applicationType1);
            _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(applicationType1.ID, CommonMessages.EntityAdded);
        }

        public async Task<IDataResult<List<ApplicationTypeDto>>> GetByCaseTypeID(int caseTypeID)
        {
            List<ApplicationType> applicationTypes = await _applicationTypeDal.GetAllQueryable(a=>a.CaseTypeID.Equals(caseTypeID)).ToListAsync();
            return new SuccessDataResult<List<ApplicationTypeDto>>(_mapper.Map<List<ApplicationTypeDto>>(applicationTypes));
        }

        public async Task<IDataResult<ApplicationType>> Get(int applicationTypeID)
        {
            ApplicationType applicationTypes =await _applicationTypeDal.GetByIdAsync(applicationTypeID);
            return new SuccessDataResult<ApplicationType>(applicationTypes);
        }

        public async Task<IResult> Update(ApplicationType basvuruTur)
        {
            throw new NotImplementedException();
        }
    }
}
