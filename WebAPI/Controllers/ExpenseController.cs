using Business.Abstract;
using Entities.Dto.ExpenseDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _expenseService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _expenseService.GetById(id);
            return Ok(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            var result = await _expenseService.GetByUserId(userId);
            return Ok(result);
        }

      

        [HttpGet]
        public async Task<IActionResult> GetByDateRange([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _expenseService.GetByDateRange(startDate, endDate);
            return Ok(result);
        }

        [HttpGet("{paymentStatus}")]
        public async Task<IActionResult> GetByPaymentStatus(int paymentStatus)
        {
            var result = await _expenseService.GetByPaymentStatus(paymentStatus);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ExpenseAddDto expenseDto)
        {
            var result = await _expenseService.Add(expenseDto);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ExpenseUpdateDto expenseDto)
        {
            var result = await _expenseService.Update(expenseDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _expenseService.Delete(id);
            return Ok(result);
        }
    }

}
