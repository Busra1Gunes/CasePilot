using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasvuruTurleriController : ControllerBase
    {
        readonly IBasvuruTurService _basvuruTurService;
        public BasvuruTurleriController(IBasvuruTurService basvuruTurService)
        {
            _basvuruTurService = basvuruTurService;
        }
        [HttpGet("/basvuruturleri")]
        public IActionResult Get() => Ok(_basvuruTurService.GetAll());
    }
}
