using Business.Abstract;
using Entities.Dto.AddDto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class DefendantsController : ControllerBase
    {
        IDefendantService _defendantService;

        public DefendantsController(IDefendantService defendantService)
        {
            _defendantService = defendantService;
        }
        [HttpPost]
        public async Task<IActionResult> Add(DefendantAddDto defendantAddDto) 
            => Ok(await _defendantService.AddDefendat(defendantAddDto));
      
        [HttpGet]
        public async Task<IActionResult> GetAll() 
            => Ok(await _defendantService.GetAllDefendant());

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
              => Ok(await _defendantService.DeleteDefendantAsync(id));
    }
}
