using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.ApplicationTypeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationTypeService
    {
        Task<IDataResult<List<ApplicationTypeDto>>> GetByCaseTypeID(int caseTypeID);
        Task<IDataResult<ApplicationType>> Get(int applicationTypeID);
        Task<IResult> Add(ApplicationTypeDto applicationType);
        Task<IResult> Update(ApplicationType applicationType);
    }
}
