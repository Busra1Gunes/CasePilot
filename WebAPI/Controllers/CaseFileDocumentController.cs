using Business.Abstract;
using Entities.Dto.AddDto;
using Entities.Dto.DocumentDto;
using Entities.Dto.DosyaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseFileDocumentController : ControllerBase
    {
        ICaseFileDocumentService _caseFileDocumentService;
        public CaseFileDocumentController(ICaseFileDocumentService caseFileDocumentService)
        {
            _caseFileDocumentService = caseFileDocumentService;
        }
        [HttpGet("/CaseFileDocumentList")]
        public IActionResult CaseFileDocumentList(int caseFileID) => Ok(_caseFileDocumentService.GetAllByCaseFileID(caseFileID));

        [HttpGet("/CaseFileDocumentByID")]
        public IActionResult CaseFileDocumentByID(int documentID) => Ok(_caseFileDocumentService.GetById(documentID));

        [HttpPost("CaseFileDocumentAdd")]
        public IActionResult CaseFileDocumentAdd([FromForm] CaseFileDocumentAddDto documentName)
        {
            var baseUri = new Uri(this.Request.GetEncodedUrl());
            var baseUrl = $"{baseUri.GetLeftPart(UriPartial.Authority)}{this.Request.PathBase}/";
            int userID = Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var result = _caseFileDocumentService.AddAsync(documentName, baseUrl).Result;

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("/documnetTypeAdd")]
        public IActionResult documnetAdd(DocumentTypeAddDto documentTypeAdd)
        {

            var result = _caseFileDocumentService.AddDocumentType(documentTypeAdd);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("/documentTypeList")]
        public IActionResult documentList() => Ok(_caseFileDocumentService.GetAllDocumentType());
    }
}
