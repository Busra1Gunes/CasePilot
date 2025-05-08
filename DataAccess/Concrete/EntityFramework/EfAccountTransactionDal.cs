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
	public class EfAccountTransactionDal : EfEntityRepositoryBase<AccountTransaction, CaseFileContext>, IAccountTransactionDal
	{
		public EfAccountTransactionDal(CaseFileContext context) : base(context)
		{
		}
	}
}
