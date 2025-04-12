using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class AccountBalanceDto
    {
        public decimal TotalDebt { get; set; } //ToplamBorc
        public decimal TotalCredit { get; set; } //ToplamAlacak
        public decimal PendingDebt { get; set; } //BekleyenBorc
        public decimal PendingCredit { get; set; }  //BekleyenAlacak
        public decimal NetBalance { get; set; }  //NetBakiye
    }
}
