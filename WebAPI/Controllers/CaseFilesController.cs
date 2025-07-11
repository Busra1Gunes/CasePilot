using Business.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{

	[Route("api/[controller]/[action]")]
	[ApiController]
    [Authorize]
    public class CaseFileController : ControllerBase
    {
        private readonly ICaseFileService _caseFileService;

        public CaseFileController(ICaseFileService caseFileService)
        {
            _caseFileService = caseFileService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CaseFileAddDto caseFile) 
            => Ok(await _caseFileService.Add(caseFile));

        [HttpGet]
        public async Task<IActionResult> Get(int caseFileID) 
            => Ok(await _caseFileService.GetById(caseFileID));

        [HttpGet]
        public async Task<IActionResult> GetAll() 
            => Ok(await _caseFileService.GetAll());

        
        [HttpGet]
        public async Task<IActionResult> GetByCaseTypeID(int caseTypeID) 
            => Ok(await _caseFileService.GetAllByCaseTypeId(caseTypeID));
       
      
        [HttpPut]
        public async Task<IActionResult> Update(int caseFileID, [FromBody] CaseFileUpdateDto caseFileUpdate)     
            =>Ok(await _caseFileService.Update(caseFileID, caseFileUpdate));

        [HttpDelete]
        public async Task<IActionResult> Delete(int caseFileID)
          => Ok(await _caseFileService.Delete(caseFileID));

    }
}