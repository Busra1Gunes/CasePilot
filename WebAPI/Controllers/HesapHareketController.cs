using Business.Abstract;
using Entities.Dto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HesapHareketController : ControllerBase
    {
        readonly IHesapHareketService _hareketService;
        public HesapHareketController(IHesapHareketService hareketService)
        {
            _hareketService = hareketService;
        }
        [HttpPost("/hareketEkle")]
        public IActionResult HesapHareketEkle(HesapHareketEkleDto hareket) => Ok(_hareketService.Add(hareket));


    }
}
