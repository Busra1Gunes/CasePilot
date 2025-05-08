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
        public async Task<IActionResult> Add(CaseFileAddDto caseFile) => Ok(await _caseFileService.Add(caseFile));
        
        
        [HttpGet("{caseFileID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CaseFileDetail(int caseFileID)
        {
            var result = _caseFileService.GetById(caseFileID);
            return result.Success ? Ok(result) : NotFound(result);
        }

        
        [HttpGet("list")]     
        [ProducesResponseType(StatusCodes.Status200OK)]
     
        public IActionResult CaseFileList()
        {
            var result = _caseFileService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

       
        [HttpGet("by-davatur/{davaTurId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CaseFileListByCaseTypeID(int caseTypeID)
        {
            var result = _caseFileService.GetAllByCaseTypeId(caseTypeID);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [SwaggerOperation(Summary = "Update CaseFiles")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update([FromBody] CaseFileUpdateDto caseFileUpdate)     
            =>Ok(await _caseFileService.Update(caseFileUpdate));
      
    }
}