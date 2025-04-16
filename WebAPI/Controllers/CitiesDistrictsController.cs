using Business.Abstract;
using Entities.Dto.AddDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesDistrictsController : ControllerBase
    {
        ICityDistrictService _cityDistrictService;

        public CitiesDistrictsController(ICityDistrictService cityDistrictService)
        {
            _cityDistrictService = cityDistrictService;
        }
      
        [HttpGet("/cityList")]
        public IActionResult cityList() => Ok(_cityDistrictService.GetAllCity());

        [HttpGet("/districtList")]
        public IActionResult districtList(int CityID) => Ok(_cityDistrictService.DistrictList(CityID));
    }
}
