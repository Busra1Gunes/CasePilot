using Business.Abstract;
using Entities.Dto.AddDto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DefendantsController : ControllerBase
    {
        IDefendantService _defendantService;

        public DefendantsController(IDefendantService defendantService)
        {
            _defendantService = defendantService;
        }



        [HttpPost("/defendantAdd")]
        public IActionResult DefendantAdd(DefendantAddDto defendantAddDto)
        {

            var result = _defendantService.AddDefendat(defendantAddDto);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("/defendantList")]
        public IActionResult DefendantList() => Ok(_defendantService.GetAllDefendant());

    }
}
