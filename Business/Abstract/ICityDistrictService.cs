using Core.Utilities.Results;
using Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityDistrictService
    {
        IDataResult<List<CityListDto>> GetAllCity();

        IDataResult<List<DistrictListDto>> DistrictList(int cityID);
    }
}
