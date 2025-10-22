using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class AccountTransactionDto
    {
        public int ID { get; set; }

        public string Debtor { get; set; }

        public string Credit { get; set; }

        public string CaseFile { get; set; }

        public decimal Amount { get; set; }


        public string TransactionStatus { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }         // Aciklama → Description
        public DateTime PaymentReceivedDate { get; set; }// OdemeYapıldığıTarih → PaymentReceivedDate
        public DateTime FinalPaymentDate { get; set; }  // SonOdemeTarihi → FinalPaymentDate

        public string PaymentStatus { get; set; }


    }
}
