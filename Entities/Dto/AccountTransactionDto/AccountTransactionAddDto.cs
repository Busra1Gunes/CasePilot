using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class AccountTransactionAddDto
    {
        public int ID { get; set; }
        public int DebtorID { get; set; }

        public int CreditID { get; set; }

        public int? caseFileID { get; set; } //Eger HareketTuru=DosyaMasrafi ise caseFileID deger alır yoksa null

        public decimal Amount { get; set; }             // Tutar → Amount
        public TransactionStatus TransactionStatus { get; set; }   // HareketDurumu → TransactionStatus
        public TransactionType Type { get; set; }       // HareketTuru → TransactionType
        public string Description { get; set; }         // Aciklama → Description
        public DateTime PaymentDate { get; set; }       // OdemeTarihi → PaymentDate
        public DateTime PaymentReceivedDate { get; set; }// OdemeYapıldığıTarih → PaymentReceivedDate
        public DateTime FinalPaymentDate { get; set; }  // SonOdemeTarihi → FinalPaymentDate
        public bool PaymentStatus { get; set; }         // OdemeDurumu → PaymentStatus
    }
}
