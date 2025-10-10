using Business.Abstract;
using Entities.Dto.IncomeDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _incomeService;

        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _incomeService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _incomeService.GetById(id);
            return Ok(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            var result = await _incomeService.GetByUserId(userId);
            return Ok(result);
        }

        [HttpGet("{caseFileId}")]
        public async Task<IActionResult> GetByCaseFileId(int caseFileId)
        {
            var result = await _incomeService.GetByCaseFileId(caseFileId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByDateRange([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _incomeService.GetByDateRange(startDate, endDate);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] IncomeAddDto incomeDto)
        {
            var result = await _incomeService.Add(incomeDto);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] IncomeUpdateDto incomeDto)
        {
            var result = await _incomeService.Update(incomeDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _incomeService.Delete(id);
            return Ok(result);
        }
    }

}
