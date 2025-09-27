using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.DosyaDto;
using Entities.Dto.KullaniciDto;
using Entities.Dto.UserDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.ComponentModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IUserService _userService;
        readonly IAuthService _authService;

        public UsersController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpGet]
        [Authorize] // Sadece giriş yapmış kullanıcılar
        public async Task<IActionResult> GetAll()
            => Ok(await _userService.GetAll());

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get(int userID)
            => Ok(await _userService.GetById(userID));

        [HttpPost]
      //  [Authorize(Roles = "Admin")] // Sadece admin ekleyebilir
        public async Task<IActionResult> Add([FromBody] UserAddDto user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Add(user);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto userRegisterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.Register(userRegisterDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.Login(userLoginDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UploadExcel(IFormFile file)
        {
            if (file == null)
                return BadRequest("Dosya seçilmedi.");

            var result = await _userService.AddFromExcel(file);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(int userID, [FromBody] UserUpdateDto userUpdateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Kullanıcı sadece kendi profilini güncelleyebilir veya admin olmalı
            var currentUserId = GetCurrentUserId();
            var isAdmin = User.IsInRole("Admin");

            //if (currentUserId != userID && !isAdmin)
            //    return Forbid("Bu işlem için yetkiniz yok.");

            var result = await _userService.Update(userID, userUpdateDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateProfile([FromBody] UserProfileUpdateDto profileDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var currentUserId = GetCurrentUserId();
            var result = await _userService.UpdateProfile(currentUserId, profileDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var currentUserId = GetCurrentUserId();
            var result = await _userService.ChangePassword(currentUserId, changePasswordDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int userID)
        {
            var result = await _userService.DeleteById(userID);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.ForgotPassword(forgotPasswordDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto resetPasswordDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.ResetPassword(resetPasswordDto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetCurrentUser()
        {
            var currentUserId = GetCurrentUserId();
            var result = await _userService.GetById(currentUserId);
            return Ok(result);
        }

        // Helper method - JWT token'dan user ID'sini al
        private int GetCurrentUserId()
        {
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value;
            return int.TryParse(userIdClaim, out var userId) ? userId : 0;
        }

        // Helper method - JWT token'dan email'i al
        private string GetCurrentUserEmail()
        {
            return User.Claims.FirstOrDefault(x => x.Type == "email")?.Value ?? string.Empty;
        }
    }
}