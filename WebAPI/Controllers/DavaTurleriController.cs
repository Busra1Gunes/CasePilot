using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DavaTurleriController : ControllerBase
	{
		readonly IDavaTurService _davaTurService;

        public DavaTurleriController(IDavaTurService davaTurService)
		{
			_davaTurService = davaTurService;
		}

    
        [HttpGet("/davaturleri")]
		public IActionResult Get()=>Ok(_davaTurService.GetAll());
	}
}
