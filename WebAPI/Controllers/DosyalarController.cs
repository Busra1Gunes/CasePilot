using Business.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    // Bu attribute, controller'ın route adresini belirler. [controller] yerine sınıf adı (Dosyalar) otomatik geçer.
    [Route("api/[controller]")]
    [ApiController] // Bu attribute ile model binding, validation, otomatik 400 dönüşü gibi özellikler aktif olur.
    //[Authorize] // Tüm işlemler için yetkilendirme zorunlu. (İsteğe bağlı kaldırılabilir)
    public class DosyalarController : ControllerBase
    {
        private readonly IDosyaService _dosyaService;

        // IDosyaService DI (Dependency Injection) ile constructor üzerinden enjekte edilir.
        public DosyalarController(IDosyaService dosyaService)
        {
            _dosyaService = dosyaService;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)] // Başarılı dönüş tipi
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // Hatalı istek tipi
        public IActionResult DosyaKayit([FromBody] DosyaKayitDto dosya)
        {
            var result = _dosyaService.Add(dosya);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpGet("{dosyaNo:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DosyaDetay(int dosyaNo)
        {
            var result = _dosyaService.GetById(dosyaNo);
            return result.Success ? Ok(result) : NotFound(result);
        }

           [Authorize]
        [HttpGet("list")]
       // [AllowAnonymous] // Bu endpoint herkese açık olabilir (örnek)
        [ProducesResponseType(StatusCodes.Status200OK)]
     
        public IActionResult DosyaListesi()
        {
            var result = _dosyaService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        
        [HttpGet("by-davatur/{davaTurId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DavayaGoreDosyaListesi(int davaTurId)
        {
            var result = _dosyaService.GetAllByDavaTurId(davaTurId);
            return result.Success ? Ok(result) : BadRequest(result);
        }

         [SwaggerOperation(Summary = "Dosyaları Günceller")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DosyaGuncelle([FromBody] DosyaGuncelleDto dosya)
        {
            var result = _dosyaService.Update(dosya);
            return result.Success ? Ok(result) : BadRequest(result);
        }       
    }
}