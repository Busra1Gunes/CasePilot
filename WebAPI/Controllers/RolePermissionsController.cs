using Business.Abstract;
using Entities.Dto.PermissionDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolePermissionsController : ControllerBase
    {
        private readonly IRolePermissionService _rolePermissionService;

        public RolePermissionsController(IRolePermissionService rolePermissionService)
        {
            _rolePermissionService = rolePermissionService;
        }

        /// <summary>
        /// Role’a tek bir yetki ekler
        /// </summary>
        [HttpPost("add")]
        public async Task<IActionResult> AddPermissionToRole([FromQuery] int roleId, [FromQuery] int permissionId)
        {
            var result = await _rolePermissionService.AddPermissionToRoleAsync(roleId, permissionId);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }

        /// <summary>
        /// Role’a birden fazla yetki ekler
        /// </summary>
        [HttpPost("add-multiple")]
        public async Task<IActionResult> AddPermissionsToRole([FromBody] RolePermissionAddDto dto)
        {
            var result = await _rolePermissionService.AddPermissionsToRoleAsync(dto);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }

        /// <summary>
        /// Role’den bir yetkiyi kaldırır
        /// </summary>
        [HttpDelete("remove")]
        public async Task<IActionResult> RemovePermissionFromRole([FromQuery] int roleId, [FromQuery] int permissionId)
        {
            var result = await _rolePermissionService.RemovePermissionFromRoleAsync(roleId, permissionId);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }

        /// <summary>
        /// Role’nin tüm yetkilerini temizler
        /// </summary>
        [HttpDelete("clear/{roleId}")]
        public async Task<IActionResult> ClearPermissionsFromRole(int roleId)
        {
            var result = await _rolePermissionService.ClearPermissionsFromRoleAsync(roleId);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }

        /// <summary>
        /// Role ait tüm yetkileri getirir
        /// </summary>
        [HttpGet("{roleId}/permissions")]
        public async Task<IActionResult> GetPermissionsByRole(int roleId)
        {
            var permissions = await _rolePermissionService.GetPermissionsByRoleAsync(roleId);
            if (permissions == null )
                return NotFound("Role ait aktif yetki bulunamadı");

            return Ok(permissions);
        }
    }
}
