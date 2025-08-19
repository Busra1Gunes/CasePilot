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
    public class EfRolePermissionDal : EfEntityRepositoryBase<RolePermission, CasePilotContext>, IRolePermissionDal
    {
        public EfRolePermissionDal(CasePilotContext context) : base(context)
        {
        }
    }
}
