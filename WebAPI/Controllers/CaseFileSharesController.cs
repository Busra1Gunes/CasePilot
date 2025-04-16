using Business.Abstract;
using Entities.Dto.CaseFileDto;
using Entities.Dto.HesapHareketDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseFileSharesController : ControllerBase
    {
        ICaseFileShareService _caseFileShareService;
        public CaseFileSharesController(ICaseFileShareService caseFileShareService)
        {
            _caseFileShareService = caseFileShareService;
        }
        [SwaggerOperation(Summary = "")]
        [HttpPost("/CaseFileShareAdd")]
        public IActionResult CaseFileShareAdd(CaseFileShareAddDto share) => Ok(_caseFileShareService.Add(share));

        [HttpGet("/CaseFileShareList")]
        public IActionResult CaseFileShareList(int casFileID) => Ok(_caseFileShareService.GetAllByCaseFileID(casFileID));
    }
}
