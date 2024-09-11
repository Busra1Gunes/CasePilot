using AutoMapper;
using Business.Abstract;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
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
        readonly IMapper _mapper;

        public StockManager(IStockDal stockDal, IMapper mapper)
        {
            _stockDal = stockDal;
            _mapper = mapper;
        }
        // [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
        [ValidationAspect(typeof(StockValidator))]
        public IResult Add(StockDto stock)
        {
            Stock stock1 = new()
            {
                StockName = stock.StockName,
                Quantity = stock.Quantity,
                DateAdded = stock.DateAdded,
                Description = stock.Description,
                TotalValue = stock.TotalValue,
                SupplierID = stock.SupplierID,
                UnitPrice = stock.UnitPrice,

            };

            _stockDal.Add(stock1);
            return new SuccessResult("Stock created");

        }
        public IDataResult<Stock> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetAll()
        {
            var list = _stockDal.Get.ToList();
            return new
            {
                Data = _mapper.Map<List<StockListDto>>(list)
            };
            //return  new SuccessDataResult<List<Stock>>(_stockDal.GetAll());
        }
    }
}
