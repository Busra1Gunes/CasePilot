using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concrete
{
    public class AccountTransaction : Entity
    {

        public int DebtorID { get; set; }               // BorcluID → DebtorId
        public int CreditID { get; set; }               // AlacakId → CreditId

        public int? CaseFileID { get; set; } //Eger HareketTuru=DosyaMasrafi ise DosyaId deger alır dosyamasrafı değilse   null

        public decimal Amount { get; set; }             // Tutar → Amount
      //  public TransactionStatus TransactionStatus { get; set; }   // HareketDurumu → TransactionStatus
        public TransactionType Type { get; set; }       // HareketTuru → TransactionType
        public string Description { get; set; }         // Aciklama → Description
        public DateTime PaymentDate { get; set; }       // OdemeTarihi → PaymentDate
        public DateTime PaymentReceivedDate { get; set; }// OdemeYapıldığıTarih → PaymentReceivedDate
        public DateTime FinalPaymentDate { get; set; }  // SonOdemeTarihi → FinalPaymentDate
        public bool PaymentStatus { get; set; }         // OdemeDurumu → PaymentStatus

        public CaseFile CaseFile { get; set; }
        
        public User User1 { get; set; }
        
        public User User2 { get; set; }
    }
}
