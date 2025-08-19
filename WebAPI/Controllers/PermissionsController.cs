using Business.Abstract;
using Business.Concrete;
using Entities.Dto.PermissionDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionService _permissionService;
        public PermissionsController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(PermissionAddDto permissionAddDto)
            => Ok(await _permissionService.CreatePermissionAsync(permissionAddDto));

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await _permissionService.GetAllPermissionAsync());

        [HttpPut]
        public async Task<IActionResult> Update(int id, PermissionAddDto permissionAddDto)
            => Ok(await _permissionService.UpdatePermissionAsync(id, permissionAddDto));

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
            => Ok(await _permissionService.DeletePermissionAsync(id));

    }
}
