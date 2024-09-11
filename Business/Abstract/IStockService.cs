using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IStockService
	{
        Task<object> GetAll();
        IDataResult<Stock> GetById(int id);
        IResult Add(StockDto stock);

    }
}
