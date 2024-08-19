using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IRepositoryDal<T> where T : class, IEntity, new()
	{
		List<T> GetAll();
		T Get();
		

	}
}
