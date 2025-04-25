using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
    [Authorize]
    public class CaseTypesController : ControllerBase
	{
		readonly ICaseTypeService _caseTypeService;

        public CaseTypesController(ICaseTypeService caseTypeService)
		{
			_caseTypeService = caseTypeService;
		}

    
        [HttpGet("/caseTypes")]
		public IActionResult Get()=>Ok(_caseTypeService.GetAll());
	}
}
