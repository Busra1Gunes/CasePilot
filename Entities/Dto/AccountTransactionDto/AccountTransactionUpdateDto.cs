using Entities.Enums;

namespace Entities.Dto.HesapHareketDto
{
    public class AccountTransactionUpdateDto
    {
        public int? DebtorID { get; set; }

        public int? CreditID { get; set; }

        public int? caseFileID { get; set; } //Eger HareketTuru=DosyaMasrafi ise caseFileID deger alır yoksa null

        public decimal Amount { get; set; }             // Tutar → Amount
                                                        // public TransactionStatus TransactionStatus { get; set; }   // HareketDurumu → TransactionStatus
        public TransactionType Type { get; set; }       // HareketTuru → TransactionType
        public string Description { get; set; }         // Aciklama → Description
        public DateTime PaymentReceivedDate { get; set; }// OdemeYapıldığıTarih → PaymentReceivedDate
        public DateTime FinalPaymentDate { get; set; }  // SonOdemeTarihi → FinalPaymentDate
        public int PaymentStatus { get; set; }
    }
}
