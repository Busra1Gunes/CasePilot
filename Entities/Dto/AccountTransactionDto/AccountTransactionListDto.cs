using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class AccountTransactionListDto
    {
        public List<AccountTransactionDto> Transaction { get; set; }
        public AccountBalanceDto Bakiye { get; set; }
    }
}
