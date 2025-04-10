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
   
    [Route("api/[controller]")]
    [ApiController]
  
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

        
        [HttpGet("list")]     
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