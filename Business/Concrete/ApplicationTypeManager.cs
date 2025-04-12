using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
        public IResult Add(ApplicationType basvuruTur)
        {
            _applicationTypeDal.AddAsync(basvuruTur);
            return new SuccessResult();
        }

        public IDataResult<List<ApplicationType>> GetAll()
        {
            List<ApplicationType> applicationTypes = _applicationTypeDal.GetAll().ToList();
            return new SuccessDataResult<List<ApplicationType>>(applicationTypes);
        }

        public IDataResult<ApplicationType> GetById(int basvuruTurId)
        {
            ApplicationType applicationTypes = _applicationTypeDal.GetByIdAsync(basvuruTurId).Result;
            return new SuccessDataResult<ApplicationType>(applicationTypes);
        }

        public IResult Update(ApplicationType basvuruTur)
        {
            throw new NotImplementedException();
        }
    }
}
