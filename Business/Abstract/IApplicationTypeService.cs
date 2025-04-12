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
        IDataResult<List<ApplicationType>> GetAll();
        IDataResult<ApplicationType> GetById(int applicationTypeID);
        IResult Add(ApplicationType applicationType);
        IResult Update(ApplicationType applicationType);
    }
}
