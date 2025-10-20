namespace Entities.Concrete
{
    public class Income : Entity
    { // Gelir kaydı
        public int UserID { get; set; }           // Geliri kaydeden kullanıcı
        public string Title { get; set; }         // Gelir başlığı
        public string Description { get; set; }   // Açıklama
        public decimal Amount { get; set; }       // Tutar
        public DateTime IncomeDate { get; set; }  // Gelir tarihi
        public int CategoryID { get; set; }       // Gelir kategorisi

        // Navigation Properties
        public virtual User User { get; set; }
        public virtual IncomeCategory Category { get; set; }
    }
}
