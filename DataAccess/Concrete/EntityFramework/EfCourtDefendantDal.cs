using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCourtDal : EfEntityRepositoryBase<Court, CasePilotContext>, ICourtDal
    {
        public EfCourtDal(CasePilotContext context) : base(context)
        {
        }
    }
}
