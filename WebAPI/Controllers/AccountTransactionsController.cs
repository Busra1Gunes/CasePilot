using Business.Abstract;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        [SwaggerOperation(Summary = "Maaş 1,Fatura 2, Kira 3, DosyaMasrafı 4, Transfer 5, Diğer 6")]
        [HttpPost]
        public async Task<IActionResult> Add(AccountTransactionAddDto hareket) 
            => Ok(await _hareketService.Add(hareket));
      


        [HttpGet]
        public IActionResult Get(int userID) 
            => Ok(_hareketService.GetAllByUserID(userID));


    }
}
    