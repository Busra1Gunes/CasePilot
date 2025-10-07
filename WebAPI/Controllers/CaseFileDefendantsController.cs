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
	[Route("api/[controller]/[action]")]
	[ApiController]
    [Authorize]
    public class CaseFileDefendantsController : ControllerBase
    {
        ICaseFileDefendantService _caseFileDefendantService;

        public CaseFileDefendantsController(ICaseFileDefendantService caseFileDefendantService)
        {
            _caseFileDefendantService = caseFileDefendantService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CaseFileDefendantAddDto caseFileDefendantAddDto) 
            => Ok(await _caseFileDefendantService.Add(caseFileDefendantAddDto));

        [HttpGet]
        public async Task<IActionResult> GetAllByCaseFileId(int caseFileID) 
            => Ok(await _caseFileDefendantService.GetAllByCaseFileId(caseFileID));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
             => Ok(await _caseFileDefendantService.DeleteCaseFileDefendantAsync(id));
    }
}
