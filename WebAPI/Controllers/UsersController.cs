using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.KullaniciDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
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
		public async Task<IActionResult> GetAll() 
            => Ok(await _userService.GetAll());

        [HttpGet]
		public async Task<IActionResult> Get(int userID) 
            => Ok(_userService.GetById(userID).Result);

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto user) 
            => Ok(await _userService.Add(user));

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto) 
            =>Ok(await _authService.Login(userLoginDto));
               
    }
}
