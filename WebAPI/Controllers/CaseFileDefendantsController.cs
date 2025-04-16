using Business.Abstract;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Entities.Dto.AddDto;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseFileDefendantsController : ControllerBase
    {
        ICaseFileDefendantService _caseFileDefendantService;

        public CaseFileDefendantsController(ICaseFileDefendantService caseFileDefendantService)
        {
            _caseFileDefendantService = caseFileDefendantService;
        }

      
        [HttpPost("")]
        public IActionResult CaseFileDefendantAdd( CaseFileDefendantAddDto caseFileDefendantAddDto)
        {

            var result = _caseFileDefendantService.Add(caseFileDefendantAddDto);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("/caseFiledefendantList")]
        public IActionResult GetAllByCaseFileId(int caseFileID) => Ok(_caseFileDefendantService.GetAllByCaseFileId(caseFileID));
    }
}
