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
        readonly ICaseFileDocumentService _caseFileDocumentService;

        public CaseFileDocumentController(ICaseFileDocumentService caseFileDocumentService)
        {
            _caseFileDocumentService = caseFileDocumentService;
        }

        /// <summary>
        /// Dosya yükler
        /// </summary>
        /// <param name="documentDto">CaseFileID, DocumentTypeID ve DocumentUrl (IFormFile)</param>
        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] CaseFileDocumentAddDto documentDto)
        {
            // UserID'yi token'dan al (opsiyonel)
            int userID = Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

            var result = await _caseFileDocumentService.AddAsync(documentDto);
            return Ok(result);
        }

        /// <summary>
        /// Dosya günceller
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] CaseFileDocumentUpdateDto documentDto)
        {
            var result = await _caseFileDocumentService.Update(documentDto);
            return Ok(result);
        }

        /// <summary>
        /// Dosya siler
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _caseFileDocumentService.DeleteCaseFileDocumentAsync(id);
            return Ok(result);
        }

        /// <summary>
        /// Tüm evrakları listeler
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _caseFileDocumentService.GetAll();
            return Ok(result);
        }

        /// <summary>
        /// Dosyaya göre evrakları listeler
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetByCaseFileID(int caseFileID)
        {
            var result = await _caseFileDocumentService.GetAllByCaseFileID(caseFileID);
            return Ok(result);
        }

        /// <summary>
        /// ID'ye göre evrak getirir
        /// </summary>
        [HttpGet("{documentID}")]
        public async Task<IActionResult> GetById(int documentID)
        {
            var result = await _caseFileDocumentService.GetById(documentID);
            return Ok(result);
        }

        /// <summary>
        /// Dosyayı indirir
        /// </summary>
        [HttpGet("{documentID}")]
        public async Task<IActionResult> Download(int documentID)
        {
            var result = await _caseFileDocumentService.DownloadFile(documentID);

            if (!result.Success)
                return BadRequest(result);

            return File(result.Data.FileData, result.Data.ContentType, result.Data.FileName);
        }

        /// <summary>
        /// Tüm evrak türlerini listeler
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllDocumentTypes()
        {
            var result = await _caseFileDocumentService.GetAllDocumentType();
            return Ok(result);
        }

        /// <summary>
        /// Yeni evrak türü ekler
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddDocumentType([FromBody] DocumentTypeAddDto documentTypeAdd)
        {
            var result = await _caseFileDocumentService.AddDocumentType(documentTypeAdd);
            return Ok(result);
        }
    }
}
