using Business.Abstract;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DosyaDavaliController : ControllerBase
    {
        IDosyaDavaliService _dosyaDavaliService;
        public DosyaDavaliController(IDosyaDavaliService dosyaDavali)
        {
            _dosyaDavaliService = dosyaDavali;
        }
        [HttpPost("DosyaDavaliEkle")]

        public IActionResult DosyaDavaliEkle( DosyaDavaliEkleDto davali)
        {

            var result = _dosyaDavaliService.Add(davali);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
