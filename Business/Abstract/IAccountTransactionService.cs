using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountTransactionService:IService<AccountTransaction>
    {
        Task<IDataResult<List<AccountTransaction>>> GetAll();
        Task<IDataResult<AccountTransactionListDto>> GetAllByUserID(int userID);
        Task<IDataResult<AccountTransactionListDto>> GetAllByCaseFileID(int caseFileID);
        Task<IDataResult<AccountTransactionUpdateDto>> GetById(int transactionID);
        Task<IResult> Add(AccountTransactionAddDto accountTransactionAddDto);
        Task<IResult> AddWithCaseFileSharesAsync(AccountTransactionAddDto accountTransaction);
        Task<IResult> Update(int ID, AccountTransactionUpdateDto transaction);
        Task<IResult> Delete(int accountTransactionID);

        // New: toggle payment status (Ödendi <-> Ödenmedi)
        Task<IResult> TogglePaymentStatusAsync(int accountTransactionID);
    }
}
