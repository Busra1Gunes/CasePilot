using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCaseTypeDal : EfEntityRepositoryBase<CaseType, CaseFileContext>, ICaseTypeDal
    {
        public EfCaseTypeDal(CaseFileContext context) : base(context)
        {
        }
    }
}