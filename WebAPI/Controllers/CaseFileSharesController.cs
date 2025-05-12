using Business.Abstract;
using Entities.Dto.CaseFileDto;
using Entities.Dto.HesapHareketDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CaseFileSharesController : ControllerBase
    {
        ICaseFileShareService _caseFileShareService;
        public CaseFileSharesController(ICaseFileShareService caseFileShareService)
        {
            _caseFileShareService = caseFileShareService;
        }
       
        [HttpPost]
        public async Task<IActionResult> Add(CaseFileShareAddDto share) 
            => Ok(await _caseFileShareService.Add(share));

        [HttpGet]
        public async Task<IActionResult> Get(int casFileID) 
            => Ok(await _caseFileShareService.GetAllByCaseFileID(casFileID));
    }
}
