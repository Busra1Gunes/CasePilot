using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IExpenseDal : IEntityRepository<Expense>
    {
    }
}
