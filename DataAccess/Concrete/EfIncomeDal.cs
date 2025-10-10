using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfIncomeDal : EfEntityRepositoryBase<Income, CasePilotContext>, IIncomeDal
    {
        public EfIncomeDal(CasePilotContext context) : base(context)
        {
        }
    }
}
