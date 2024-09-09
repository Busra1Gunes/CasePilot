using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IStockService
	{
        IDataResult<List<Stock>> GetAll();
        IDataResult<Stock> GetById(int id);
        IResult Add(Stock stock);

    }
}
