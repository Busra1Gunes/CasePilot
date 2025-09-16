using Business.Abstract;
using Entities.Dto.HearingDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class HearingController : ControllerBase
    {
        private readonly IHearingService _hearingService;

        public HearingController(IHearingService hearingService)
        {
            _hearingService = hearingService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(HearingAddDto hearing)
            => Ok(await _hearingService.Add(hearing));

        [HttpGet]
        public async Task<IActionResult> Get(int hearingID)
            => Ok(await _hearingService.GetById(hearingID));

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _hearingService.GetAllAsync());

        [HttpGet]
        public async Task<IActionResult> GetFiltered([FromQuery] HearingFilterDto filterDto)
            => Ok(await _hearingService.GetFilteredAsync(filterDto));

        [HttpGet]
        public async Task<IActionResult> GetByCaseFileID(int caseFileID)
            => Ok(await _hearingService.GetByCaseFileId(caseFileID));

        [HttpGet]
        public async Task<IActionResult> GetByCourtID(int courtID)
            => Ok(await _hearingService.GetByCourtId(courtID));

        [HttpGet]
        public async Task<IActionResult> GetTodayHearings()
            => Ok(await _hearingService.GetTodayHearings());

        [HttpGet]
        public async Task<IActionResult> GetUpcomingHearings(int days = 7)
            => Ok(await _hearingService.GetUpcomingHearings(days));

        [HttpPut]
        public async Task<IActionResult> Update(int hearingID, [FromBody] HearingUpdateDto hearingUpdate)
            => Ok(await _hearingService.Update(hearingID, hearingUpdate));

        [HttpDelete]
        public async Task<IActionResult> Delete(int hearingID)
            => Ok(await _hearingService.Delete(hearingID));
    }
}
