using Business.Abstract;
using Core.CrossCuttingConcerns.Caching;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.AddDto;
using Entities.Dto.ListDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CitiesDistrictsController : ControllerBase
    {
        ICityDistrictService _cityDistrictService;
        ICacheService _cacheService;
        public CitiesDistrictsController(ICityDistrictService cityDistrictService,ICacheService cacheService)
        {
            _cityDistrictService = cityDistrictService;
            _cacheService = cacheService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
			string cacheKey = "cities_all";

			var cachedData = await _cacheService.GetAsync<ApiResponse<List<CityListDto>>>(cacheKey);
			if (cachedData != null)
			{
				return Ok(cachedData); // ✅ Cache'den geldi
			}

			var data = _cityDistrictService.GetAllCity(); // EF üzerinden veri çek
			await _cacheService.SetAsync(cacheKey, data, TimeSpan.FromMinutes(10)); // cache'e yaz

			return Ok(data); // ✅ DB'den geldi
		}

        [HttpGet]
        public async Task<IActionResult> Get(int CityID) 
            => Ok(_cityDistrictService.DistrictList(CityID));
    }
}
