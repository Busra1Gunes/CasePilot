using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCaseFileShareDal : EfEntityRepositoryBase<CaseFileShare, Context>, ICaseFileShareDal
    {
        public EfCaseFileShareDal(Context context) : base(context)
        {
        }
    }
}
