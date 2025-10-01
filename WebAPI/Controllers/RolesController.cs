using Business.Abstract;
using Entities.Concrete;
using Entities.Dto.RoleDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _roleService.GetAllRolesAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            => Ok(await _roleService.GetRoleByIdAsync(id));


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateRoleDto dto)
            => Ok(await _roleService.CreateRoleAsync(dto));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CreateRoleDto dto)
            => Ok(await _roleService.UpdateRoleAsync(id, dto));


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => Ok(await _roleService.DeleteRoleAsync(id));

    }
}
