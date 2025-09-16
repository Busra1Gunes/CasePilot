using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHearingDal : EfEntityRepositoryBase<Hearing, CasePilotContext>, IHearingDal
    {
        public EfHearingDal(CasePilotContext context) : base(context)
        {
        }
    }
}
