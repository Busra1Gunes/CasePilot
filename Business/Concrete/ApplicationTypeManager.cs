using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
        readonly IMapper _mapper;
        public ApplicationTypeManager(IApplicationTypeDal applicationTypeDal, IMapper mapper)
        {
            _applicationTypeDal = applicationTypeDal;
            _mapper = mapper;
        }
        public async Task<IResult> Add(ApplicationType basvuruTur)
        {
            await _applicationTypeDal.AddAsync(basvuruTur);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<ApplicationType>>> GetAll()
        {
            List<ApplicationType> applicationTypes = await _applicationTypeDal.GetAllQueryable().ToListAsync();
            return new SuccessDataResult<List<ApplicationType>>(applicationTypes);
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
