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
        readonly IAuthService _authService;
        public KullanicilarController(IKullaniciService kullaniciService,IAuthService authService)
		{
            _kullaniciService = kullaniciService;
			_authService = authService;
		}
        
        [HttpGet]
		public IActionResult Get() => Ok(_kullaniciService.GetAll().Result);

        [Authorize]
        [HttpGet("/getbyID")]
		public IActionResult GetById(int kullaniciId) => Ok(_kullaniciService.GetById(kullaniciId));

		[HttpPost]
		public IActionResult Add(KullaniciKayitDto kullanici)
		{
            var result = _kullaniciService.Add(kullanici);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [AllowAnonymous]
        [HttpPost("/Login")]
        public IActionResult Login(KullaniciLoginDto kullaniciLoginDto) => Ok(_authService.Login(kullaniciLoginDto));


    }
}
