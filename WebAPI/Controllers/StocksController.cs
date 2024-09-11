using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StocksController : ControllerBase
	{
		readonly IStockService _stockService;

		public StocksController(IStockService stockService)
		{
			_stockService = stockService;
		}

		[HttpGet]
		//	[Authorize]
		public IActionResult Get() => Ok(_stockService.GetAll());
		//{
		//	return ;
  //          //if (result.Success)
  //          //{
  //          //    return Ok(result);
  //          //}
  //          //return BadRequest(result);
  //      }


		[HttpPost]
		public IActionResult Post(StockDto stock)
		{
            var result = _stockService.Add(stock);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
	}
}
