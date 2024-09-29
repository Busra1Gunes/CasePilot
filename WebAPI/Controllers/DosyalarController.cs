using Business.Abstract;
using Entities.Concrete;
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
		[HttpPost("/dosyaKayit")]
		public IActionResult DosyaKayit(DosyaKayitDto dosya)=>Ok(_dosyaService.Add(dosya));


		[HttpGet]
		public IActionResult DosyaDetay(int DosyaNo) => Ok(_dosyaService.GetById(DosyaNo));
    }
}
