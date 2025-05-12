using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationTypeService
    {
        Task<IDataResult<List<ApplicationType>>> GetAll();
        Task<IDataResult<ApplicationType>> Get(int applicationTypeID);
        Task<IResult> Add(ApplicationType applicationType);
        Task<IResult> Update(ApplicationType applicationType);
    }
}
