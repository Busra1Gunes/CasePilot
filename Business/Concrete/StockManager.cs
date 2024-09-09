using Business.Abstract;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Messages;
using Core.Utilities.Results;
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
        // [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
        [ValidationAspect(typeof(StockValidator))]
        public IResult Add(Stock stock)
        {
           _stockDal.Add(stock);
            return new SuccessResult("created stock");
        }
        public IDataResult<Stock> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Stock>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
