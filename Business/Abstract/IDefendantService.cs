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
        Task<IDataResult<List<DefendantListDto>>> GetAllDefendant();

        Task<IResult> AddDefendat(DefendantAddDto defendantAddDto);
    }
}
