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
	public class UsersController : ControllerBase
	{
		readonly IUserService _userService;
        readonly IAuthService _authService;
        public UsersController(IUserService userService,IAuthService authService)
		{
            _userService = userService;
			_authService = authService;
		}
        
        [HttpGet]
		public IActionResult Get() => Ok(_userService.GetAll().Result);

        [Authorize]
        [HttpGet("/getbyID")]
		public IActionResult GetById(int kullaniciId) => Ok(_userService.GetById(kullaniciId));

		[HttpPost]
		public IActionResult Add(UserAddDto kullanici)
		{
            var result = _userService.Add(kullanici);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [AllowAnonymous]
        [HttpPost("/Login")]
        public IActionResult Login(UserLoginDto userLoginDto) => Ok(_authService.Login(userLoginDto));


    }
}
