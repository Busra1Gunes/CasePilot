using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ApplicationTypesController : ControllerBase
    {
        readonly IApplicationTypeService _applicationTypeService;
        public ApplicationTypesController(IApplicationTypeService applicationTypeService)
        {
            _applicationTypeService = applicationTypeService;
        }
       
        [HttpGet("/applicationTypes")]
        public IActionResult Get() => Ok(_applicationTypeService.GetAll());

       
        [HttpGet("/applicationTypes/getbyID")]
        public IActionResult GetById(int basvuruTurId) => Ok(_applicationTypeService.GetById(basvuruTurId));

      
        [HttpPost("/applicationTypes/add")]
        public IActionResult Add(ApplicationType basvuruTur) => Ok(_applicationTypeService.Add(basvuruTur));
    }
}
