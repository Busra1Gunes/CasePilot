using Core.Utilities.Results;
using Entities.Dto.AddDto;
using Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDefendantService
    {
        IDataResult<List<DefendantListDto>> GetAllDefendant();

        IResult AddDefendat(DefendantAddDto defendantAddDto);
    }
}
