using Business.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DosyalarController : ControllerBase
	{
		readonly IDosyaService _dosyaService;
        public DosyalarController(IDosyaService dosyaService)
        {
			_dosyaService = dosyaService;
        }
		[HttpPost("/dosyakayit")]
		public IActionResult DosyaKayit(DosyaKayitDto dosya)=>Ok(_dosyaService.Add(dosya));

		[HttpGet("/dosyadetay")]
		public IActionResult DosyaDetay(int DosyaNo) => Ok(_dosyaService.GetById(DosyaNo));

        [HttpPost("/dosyalistesi")]
        public IActionResult DosyaListesi() => Ok(_dosyaService.GetAll());

        [HttpGet("/dosyalistesi/davaturid")]
        public IActionResult DavayaGoreDosyaListesi(int davaturid) => Ok(_dosyaService.GetAllByDavaTurId(davaturid));

        [HttpPut("/dosyaguncelle")]
        public IActionResult DosyaGuncelle(DosyaGuncelleDto Dosya) => Ok(_dosyaService.Update(Dosya));
    }
}
