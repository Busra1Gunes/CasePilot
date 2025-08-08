using Business.Abstract;
using Entities.Dto.AddDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        IMainService _mainService;
        public MainController(IMainService mainService)
        {
            _mainService = mainService;
        }
      
        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _mainService.Totals());
    }
}
