namespace Entities.Dto.ExpenseDto
{
    public class ExpenseListDto
    {
        public int ID { get; set; }
        public string Title { get; set; }           // Başlık
        public string Description { get; set; }     // Açıklama
        public decimal Amount { get; set; }         // Tutar
        public DateTime ExpenseDate { get; set; }   // Gider tarihi
        public string UserName { get; set; }        // Kullanıcı adı
        public string CaseFileName { get; set; }    // Dosya adı
        public string CategoryName { get; set; }    // Kategori adı
        public string PaymentStatusName { get; set; } // Ödeme durumu
        public DateTime CreatedDate { get; set; }
    }
}
