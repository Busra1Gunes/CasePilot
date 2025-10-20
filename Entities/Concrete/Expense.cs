namespace Entities.Concrete
{
    public class Expense : Entity
    {  // Gider kaydı
        public int UserID { get; set; }           // Gideri kaydeden kullanıcı
        public string Title { get; set; }         // Gider başlığı
        public string Description { get; set; }   // Açıklama
        public decimal Amount { get; set; }       // Tutar
        public DateTime ExpenseDate { get; set; } // Gider tarihi
        public int CategoryID { get; set; }       // Gider kategorisi
        public int PaymentStatus { get; set; }    // Ödeme durumu (1: Ödendi, 2: Ödenmedi)

        // Navigation Properties
        public virtual User User { get; set; }
        public virtual CaseFile CaseFile { get; set; }
        public virtual ExpenseCategory Category { get; set; }
    }
}
