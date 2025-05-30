﻿using Business.Abstract;
using Entities.Dto.AddDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CitiesDistrictsController : ControllerBase
    {
        ICityDistrictService _cityDistrictService;

        public CitiesDistrictsController(ICityDistrictService cityDistrictService)
        {
            _cityDistrictService = cityDistrictService;
        }
      
        [HttpGet]
        public async Task<IActionResult> GetAll() 
            => Ok(_cityDistrictService.GetAllCity());

        [HttpGet]
        public async Task<IActionResult> Get(int CityID) 
            => Ok(_cityDistrictService.DistrictList(CityID));
    }
}
