using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityDistrictManager : ICityDistrictService
    {
        ICityDal _cityDal;
        IDistrictDal _districtDal;
        IMapper _mapper;
        public CityDistrictManager(ICityDal cityDal, IDistrictDal districtDal, IMapper mapper)
        {
            _cityDal = cityDal;
            _districtDal = districtDal;
            _mapper = mapper;
        }
        public IDataResult<List<DistrictListDto>> DistrictList(int cityID)
        {
            List<District> distiricts = _districtDal.Where(d => d.CityID.Equals(cityID)).ToList();
            var list = _mapper.Map<List<DistrictListDto>>(distiricts);
            return new SuccessDataResult<List<DistrictListDto>>(list);
        }

        public IDataResult<List<CityListDto>> GetAllCity()
        {
            List<City> cities = _cityDal.GetAll().ToList();
            var list = _mapper.Map<List<CityListDto>>(cities);
            return new SuccessDataResult<List<CityListDto>>(list);
        }
    }
}
