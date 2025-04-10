using Business.Abstract;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HesapHareketController : ControllerBase
    {
        readonly IHesapHareketService _hareketService;
        public HesapHareketController(IHesapHareketService hareketService)
        {
            _hareketService = hareketService;
        }
        [Authorize]
        [HttpPost("/hareketEkle")]
        public IActionResult HesapHareketEkle(HesapHareketEkleDto hareket) => Ok(_hareketService.Add(hareket));
        
        [Authorize]
        [HttpPost("/dosyaHareketListesi")]
        public IActionResult HesapHareketListesi(int dosyaId) => Ok(_hareketService.GetAllByDosyaId(dosyaId));


    }
}
    