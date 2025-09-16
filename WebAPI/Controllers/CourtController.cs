using Business.Abstract;
using Entities.Dto.CourtDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CourtController : ControllerBase
    {
        private readonly ICourtService _courtService;

        public CourtController(ICourtService courtService)
        {
            _courtService = courtService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CourtAddDto court)
            => Ok(await _courtService.Add(court));

        [HttpGet]
        public async Task<IActionResult> Get(int courtID)
            => Ok(await _courtService.GetById(courtID));

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _courtService.GetAllAsync());

        [HttpGet]
        public async Task<IActionResult> GetFiltered([FromQuery] CourtFilterDto filterDto)
            => Ok(await _courtService.GetFilteredAsync(filterDto));

        [HttpGet]
        public async Task<IActionResult> GetByCityID(int cityID)
            => Ok(await _courtService.GetByCityId(cityID));

        [HttpPut]
        public async Task<IActionResult> Update(int courtID, [FromBody] CourtUpdateDto courtUpdate)
            => Ok(await _courtService.Update(courtID, courtUpdate));

        [HttpDelete]
        public async Task<IActionResult> Delete(int courtID)
            => Ok(await _courtService.Delete(courtID));
    }
}
