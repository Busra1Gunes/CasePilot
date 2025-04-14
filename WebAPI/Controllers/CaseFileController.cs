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
   
    [Route("api/[controller]")]
    [ApiController]
  
    public class CaseFileController : ControllerBase
    {
        private readonly ICaseFileService _caseFileService;

        // IDosyaService DI (Dependency Injection) ile constructor üzerinden enjekte edilir.
        public CaseFileController(ICaseFileService caseFileService)
        {
            _caseFileService = caseFileService;
        }

      
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)] // Başarılı dönüş tipi
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // Hatalı istek tipi
        public IActionResult Add([FromBody] CaseFileAddDto caseFile)
        {
            var result = _caseFileService.Add(caseFile);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        
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
        public IActionResult Update([FromBody] CaseFileUpdateDto caseFileUpdate)
        {
            var result = _caseFileService.Update(caseFileUpdate);
            return result.Success ? Ok(result) : BadRequest(result);
        }       
    }
}