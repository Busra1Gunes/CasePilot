using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfExpenseCategoryDal : EfEntityRepositoryBase<ExpenseCategory, CasePilotContext>, IExpenseCategoryDal
    {
        public EfExpenseCategoryDal(CasePilotContext context) : base(context)
        {
        }
    }
}
