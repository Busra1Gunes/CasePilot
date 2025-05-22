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
    public class EfDocumentTypeDal : EfEntityRepositoryBase<DocumentType, CasePilotContext>, IDocumentTypeDal
    {
        public EfDocumentTypeDal(CasePilotContext context) : base(context)
        {
        }
    }
}
