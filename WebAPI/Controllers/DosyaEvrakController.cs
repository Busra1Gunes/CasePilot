using Business.Abstract;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DosyaEvrakController : ControllerBase
    {
        IDosyaEvrakService _evrakService;
        public DosyaEvrakController(IDosyaEvrakService evrakService)
        {
            _evrakService = evrakService;
        }

        
        [HttpPost("DosyaEvrakEkle")]
        public IActionResult DosyaEvrakEkle([FromForm] DosyaEvrakEkleDto evrakAdd)
        {
            var baseUri = new Uri(this.Request.GetEncodedUrl());
            var baseUrl = $"{baseUri.GetLeftPart(UriPartial.Authority)}{this.Request.PathBase}/";
            int kullaniciId = Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var result = _evrakService.Add(evrakAdd, baseUrl);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
