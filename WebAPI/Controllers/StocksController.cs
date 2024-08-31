using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
		[Authorize]
		public List<Stock> Get()
		{
			return _stockService.GetAll();
		}
	}
}
