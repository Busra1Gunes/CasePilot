using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IHearingDal : IEntityRepository<Hearing>
    {
        // Özel metodlar gerekirse buraya eklenebilir
    }
}
