using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CaseTypesController : ControllerBase
	{
		readonly ICaseTypeService _caseTypeService;

        public CaseTypesController(ICaseTypeService caseTypeService)
		{
			_caseTypeService = caseTypeService;
		}
    
        [HttpGet]
		public async Task<IActionResult> GetAll()
            =>Ok(await _caseTypeService.GetAll());
	}
}
