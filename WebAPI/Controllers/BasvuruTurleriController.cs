using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
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

       
        [HttpGet("/basvuruturleri/getbyID")]
        public IActionResult GetById(int basvuruTurId) => Ok(_basvuruTurService.GetById(basvuruTurId));

      
        [HttpPost("/basvuruturleri/add")]
        public IActionResult Add(BasvuruTur basvuruTur) => Ok(_basvuruTurService.Add(basvuruTur));
    }
}
