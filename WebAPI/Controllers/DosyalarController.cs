using Business.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        /// <summary>
        /// Yeni bir dosya kaydı oluşturur.
        /// </summary>
        /// <param name="dosya">Kaydedilecek dosya bilgileri</param>
        /// <returns>İşlem sonucu</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)] // Başarılı dönüş tipi
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // Hatalı istek tipi
        public IActionResult DosyaKayit([FromBody] DosyaKayitDto dosya)
        {
            var result = _dosyaService.Add(dosya);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        /// <summary>
        /// Dosya numarasına göre detay bilgisi getirir.
        /// </summary>
        /// <param name="dosyaNo">Dosya numarası</param>
        /// <returns>Dosya detay bilgisi</returns>
        [HttpGet("{dosyaNo:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DosyaDetay(int dosyaNo)
        {
            var result = _dosyaService.GetById(dosyaNo);
            return result.Success ? Ok(result) : NotFound(result);
        }

        /// <summary>
        /// Tüm dosyaların listesini döner.
        /// </summary>
        /// <returns>Dosya listesi</returns>
        [HttpGet("list")]
        [AllowAnonymous] // Bu endpoint herkese açık olabilir (örnek)
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DosyaListesi()
        {
            var result = _dosyaService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        /// <summary>
        /// Belirli bir dava türüne ait dosyaları listeler.
        /// </summary>
        /// <param name="davaTurId">Dava türü ID</param>
        /// <returns>Filtrelenmiş dosya listesi</returns>
        [HttpGet("by-davatur/{davaTurId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DavayaGoreDosyaListesi(int davaTurId)
        {
            var result = _dosyaService.GetAllByDavaTurId(davaTurId);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        /// <summary>
        /// Mevcut bir dosyayı günceller.
        /// </summary>
        /// <param name="dosya">Güncellenmek istenen dosya bilgileri</param>
        /// <returns>İşlem sonucu</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DosyaGuncelle([FromBody] DosyaGuncelleDto dosya)
        {
            var result = _dosyaService.Update(dosya);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        /// <summary>
        /// Belirli bir dosyayı siler. (opsiyonel olarak eklendi)
        /// </summary>
        /// <param name="id">Silinecek dosya ID</param>
        /// <returns>İşlem sonucu</returns>
        //[HttpDelete("{id:int}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public IActionResult DosyaSil(int id)
        //{
        //    var result = _dosyaService.(id);
        //    return result.Success ? Ok(result) : NotFound(result);
        //}
    }
}