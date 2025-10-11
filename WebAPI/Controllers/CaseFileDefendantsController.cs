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

        // MEVCUT ENDPOINT'LER (Değiştirilmedi)
        [HttpPost]
        public async Task<IActionResult> Add(CaseFileDefendantAddDto caseFileDefendantAddDto)
            => Ok(await _caseFileDefendantService.Add(caseFileDefendantAddDto));

        [HttpGet]
        public async Task<IActionResult> GetAllByCaseFileId(int caseFileID)
            => Ok(await _caseFileDefendantService.GetAllByCaseFileId(caseFileID));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => Ok(await _caseFileDefendantService.DeleteCaseFileDefendantAsync(id));

        // ============================================
        // YENİ EKLENEN ENDPOINT'LER
        // ============================================

        /// <summary>
        /// Tüm dosya davalılarını getirir
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _caseFileDefendantService.GetAll());

        /// <summary>
        /// ID'ye göre dosya davalısı getirir
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
            => Ok(await _caseFileDefendantService.GetById(id));

        /// <summary>
        /// Dosya davalısını günceller
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CaseFileDefendantUpdateDto caseFileDefendant)
            => Ok(await _caseFileDefendantService.Update(caseFileDefendant));

        /// <summary>
        /// Tüm davalıları getirir (Defendant listesi)
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllDefendants()
            => Ok(await _caseFileDefendantService.GetAllDefendant());

        /// <summary>
        /// Yeni davalı ekler (Defendant tablosuna)
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddDefendant([FromBody] DefendantAddDto defendantAddDto)
            => Ok(await _caseFileDefendantService.AddDefendat(defendantAddDto));
    }
}
