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
	[Route("api/[controller]/[action]")]
	[ApiController]
    [Authorize]
    public class CaseFileDocumentController : ControllerBase
    {
        ICaseFileDocumentService _caseFileDocumentService;
        public CaseFileDocumentController(ICaseFileDocumentService caseFileDocumentService)
        {
            _caseFileDocumentService = caseFileDocumentService;
        }
        [HttpGet]
        public IActionResult GetByCaseFileID(int caseFileID) 
            => Ok(_caseFileDocumentService.GetAllByCaseFileID(caseFileID));

        [HttpGet]
        public async Task<IActionResult> GetDocumentByID(int documentID) 
            => Ok(await _caseFileDocumentService.GetById(documentID));

        [HttpPost]
        public async Task<IActionResult> AddCaseFileDocument([FromForm] CaseFileDocumentAddDto documentName)
        {
            var baseUri = new Uri(this.Request.GetEncodedUrl());
            var baseUrl = $"{baseUri.GetLeftPart(UriPartial.Authority)}{this.Request.PathBase}/";
            int userID = Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
           return Ok(await _caseFileDocumentService.AddAsync(documentName, baseUrl));    
        }

        [HttpPost]
        public async Task<IActionResult> AddDocument(DocumentTypeAddDto documentTypeAdd) 
            => Ok(await _caseFileDocumentService.AddDocumentType(documentTypeAdd));
        
        [HttpGet]
		public async Task<IActionResult> GetAllDocument()
            => Ok(await _caseFileDocumentService.GetAllDocumentType());

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
             => Ok(await _caseFileDocumentService.DeleteCaseFileDocumentAsync(id));
    }
}
