using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class StockManager : IStockService
	{
		IStockDal _stockDal;
        public StockManager(IStockDal stockDal )
        {
				_stockDal = stockDal;
        }
        public List<Stock> GetAll()
		{
			return _stockDal.GetAll();
		}

		public Stock GetById(int id)
		{
			return _stockDal.Get(s=>s.Id.Equals(id));
		}
	}
}
