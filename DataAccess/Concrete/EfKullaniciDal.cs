using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, Context>, IKullaniciDal
    {
        public EfKullaniciDal(Context context) : base(context)
        {
        }
    }
}
