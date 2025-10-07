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
        public async Task<IActionResult> GetAll(int caseTypeID) 
            => Ok(await _applicationTypeService.GetByCaseTypeID(caseTypeID));

       
        [HttpGet]
        public async Task<IActionResult> Get(int applicationTypeID) 
            => Ok(await _applicationTypeService.Get(applicationTypeID));

      
        [HttpPost]
        public async Task<IActionResult> Add(ApplicationTypeAddDto applicationType) 
            => Ok(await _applicationTypeService.Add(applicationType));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
                => Ok(await _applicationTypeService.DeleteApplicationTypeAsync(id));
    }
}
