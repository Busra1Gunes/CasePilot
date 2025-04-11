using Business.Abstract;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(Summary = "Maaş 1,Fatura 2, Kira 3, DosyaMasrafı 4, transfer 5, Diğer 6")]
        [HttpPost("/hareketEkle")]
        public IActionResult HesapHareketEkle(HesapHareketEkleDto hareket) => Ok(_hareketService.Add(hareket));
      


        [HttpPost("/kullaniciHareketListesi")]
        public IActionResult KullaniciHesapHareketListesi(int userID) => Ok(_hareketService.GetAllByUserID(userID));


    }
}
    