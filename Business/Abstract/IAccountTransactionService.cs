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
    public interface IAccountTransactionService
    {
        IDataResult<List<AccountTransaction>> GetAll();
        IDataResult<AccountTransactionListDto> GetAllByUserID(int userID);

        IDataResult<AccountTransaction> GetById(int hareketId);
        IResult Add(AccountTransactionAddDto hareket);
        IResult Update(AccountTransaction hareket);
    }
}
