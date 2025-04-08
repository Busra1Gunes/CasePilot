using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.KullaniciDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class KullanicilarController : ControllerBase
	{
		readonly IKullaniciService _kullaniciService;

		public KullanicilarController(IKullaniciService kullaniciService)
		{
            _kullaniciService = kullaniciService;
		}

		[HttpGet]
		public IActionResult Get() => Ok(_kullaniciService.GetAll().Result);


		[HttpGet("/getbyID")]
		public IActionResult GetById(int kullaniciId) => Ok(_kullaniciService.GetById(kullaniciId));

		[HttpPost]
		public IActionResult Post(KullaniciKayitDto kullanici)
		{
            var result = _kullaniciService.Add(kullanici);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
	}
}
