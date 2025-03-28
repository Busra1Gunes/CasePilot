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
    public class EfDosyaDavaliDal : EfEntityRepositoryBase<DosyaDavali, Context>, IDosyaDavaliDal
    {
        public EfDosyaDavaliDal(Context context) : base(context)
        {
        }
    }
}
