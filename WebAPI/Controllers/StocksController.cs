using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StocksController : ControllerBase
	{
		[HttpGet]
		public string Get() => "Merhaba";
	}
}
