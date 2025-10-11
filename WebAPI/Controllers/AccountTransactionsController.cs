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
        readonly IAccountTransactionService _hareketService;

        public AccountTransactionsController(IAccountTransactionService hareketService)
        {
            _hareketService = hareketService;
        }

        [SwaggerOperation(Summary = "Maaş 1, Fatura 2, Kira 3, DosyaMasrafı 4, Transfer 5, Diğer 6")]
        [HttpPost]
        public async Task<IActionResult> Add(AccountTransactionAddDto hareket)
            => Ok(await _hareketService.Add(hareket));

        [HttpGet]
        public async Task<IActionResult> Get(int userID)
            => Ok(await _hareketService.GetAllByUserID(userID));

        [HttpGet]
        public async Task<IActionResult> GetByCaseFileID(int caseFileID)
            => Ok(await _hareketService.GetAllByCaseFileID(caseFileID));

        [HttpDelete]
        public async Task<IActionResult> Delete(int accountTransactionID)
            => Ok(await _hareketService.Delete(accountTransactionID));

        /// <summary>
        /// Tüm hesap hareketlerini getirir
        /// </summary>
        [HttpGet]
        [SwaggerOperation(Summary = "Tüm hesap hareketlerini listeler")]
        public async Task<IActionResult> GetAll()
            => Ok(await _hareketService.GetAll());

        /// <summary>
        /// ID'ye göre tek bir hesap hareketi getirir
        /// </summary>
        [HttpGet("{transactionID}")]
        [SwaggerOperation(Summary = "ID'ye göre hesap hareketi getirir")]
        public async Task<IActionResult> GetById(int transactionID)
            => Ok(await _hareketService.GetById(transactionID));

        /// <summary>
        /// Hesap hareketi günceller
        /// </summary>
        [HttpPut]
        [SwaggerOperation(Summary = "Hesap hareketi günceller")]
        public async Task<IActionResult> Update([FromBody] AccountTransaction transaction)
            => Ok(await _hareketService.Update(transaction));
    }
}
