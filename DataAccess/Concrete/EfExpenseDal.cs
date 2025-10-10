using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfExpenseDal : EfEntityRepositoryBase<Expense, CasePilotContext>, IExpenseDal
    {
        public EfExpenseDal(CasePilotContext context) : base(context)
        {
        }
    }
}
