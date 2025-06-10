using Business.Abstract;
using Entities.Concrete;
using Entities.Dto.ApplicationTypeDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ApplicationTypesController : ControllerBase
    {
        readonly IApplicationTypeService _applicationTypeService;
        public ApplicationTypesController(IApplicationTypeService applicationTypeService)
        {
            _applicationTypeService = applicationTypeService;
        }
       
        [HttpGet]
        public async Task<IActionResult> GetAll() 
            => Ok(await _applicationTypeService.GetAll());

       
        [HttpGet]
        public async Task<IActionResult> Get(int applicationTypeID) 
            => Ok(await _applicationTypeService.Get(applicationTypeID));

      
        [HttpPost]
        public async Task<IActionResult> Add(ApplicationTypeDto applicationType) 
            => Ok(await _applicationTypeService.Add(applicationType));
    }
}
