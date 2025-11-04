using Business.Abstract;
using Entities.Concrete;
using Entities.Dto.HesapHareketDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AccountTransactionsController : ControllerBase
    {
        readonly IAccountTransactionService _transactionService;

        public AccountTransactionsController(IAccountTransactionService accountTransactionService)
        {
            _transactionService = accountTransactionService;
        }

        [SwaggerOperation(Summary = "Maaş 1, Fatura 2, Kira 3, DosyaMasrafı 4, Transfer 5, Diğer 6")]
        [HttpPost]
        public async Task<IActionResult> Add(AccountTransactionAddDto accountTransaction)
            => Ok(await _transactionService.Add(accountTransaction));


        [SwaggerOperation(Summary = "Maaş 1, Fatura 2, Kira 3, DosyaMasrafı 4, Transfer 5, Diğer 6")]
        [HttpPost]
        public async Task<IActionResult> AddCaseFile(AccountTransactionAddDto accountTransaction)
          => Ok(await _transactionService.AddWithCaseFileSharesAsync(accountTransaction));

        [HttpGet]
        public async Task<IActionResult> Get(int userID)
            => Ok(await _transactionService.GetAllByUserID(userID));

        [HttpGet]
        public async Task<IActionResult> GetByCaseFileID(int caseFileID)
            => Ok(await _transactionService.GetAllByCaseFileID(caseFileID));

        [HttpDelete]
        public async Task<IActionResult> Delete(int accountTransactionID)
            => Ok(await _transactionService.Delete(accountTransactionID));

        /// <summary>
        /// Tüm hesap hareketlerini getirir
        /// </summary>
        [HttpGet]
        [SwaggerOperation(Summary = "Tüm hesap hareketlerini listeler")]
        public async Task<IActionResult> GetAll()
            => Ok(await _transactionService.GetAll());

        /// <summary>
        /// ID'ye göre tek bir hesap hareketi getirir
        /// </summary>
        [HttpGet("{transactionID}")]
        [SwaggerOperation(Summary = "ID'ye göre hesap hareketi getirir")]
        public async Task<IActionResult> GetById(int transactionID)
            => Ok(await _transactionService.GetById(transactionID));

        /// <summary>
        /// Hesap hareketi günceller
        /// </summary>
        [HttpPut]
        [SwaggerOperation(Summary = "Hesap hareketi günceller")]
        public async Task<IActionResult> Update(int ID,[FromBody] AccountTransactionUpdateDto transaction)
            => Ok(await _transactionService.Update(ID,transaction));


        /// <summary>
        /// Ödeme durumunu tersine çevirir: Ödendi (1) -> Ödenmedi (2), Ödenmedi (2) -> Ödendi (1).
        /// Diğer durumlar için varsayılan olarak Ödendi (1) olur.
        /// </summary>
        [HttpPost]
        [SwaggerOperation(Summary = "Ödeme durumu: Ödendi <-> Ödenmedi (toggle)")]
        public async Task<IActionResult> TogglePaymentStatus(int transactionID)
        {
            var result = await _transactionService.TogglePaymentStatusAsync(transactionID);
            if (result == null)
                return StatusCode(500, "Beklenmeyen bir hata oluştu.");

            if (result.Success)
                return Ok(result);

            // Hata durumunda uygun status kodu dönebiliriz (400/404/500). Service mesajına göre 400 döndürüyoruz.
            return BadRequest(result);
        }
    }
}
