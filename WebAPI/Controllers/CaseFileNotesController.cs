using Business.Abstract;
using Entities.Dto.CaseFileDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CaseFileNotesController : ControllerBase
    {
        private readonly ICaseFileNoteService _noteService;

        public CaseFileNotesController(ICaseFileNoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("{caseFileId}")]
        public async Task<IActionResult> GetByCaseFileId(int caseFileId)
        {
            var result = await _noteService.GetByCaseFileId(caseFileId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CaseFileNoteAddDto noteDto)
        {
            var result = await _noteService.Add(noteDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _noteService.Delete(id);
            return Ok(result);
        }
    }
}
