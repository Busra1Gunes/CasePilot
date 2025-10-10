namespace Entities.Dto.IncomeDto
{
    public class IncomeListDto
    {
        public int ID { get; set; }
        public string Title { get; set; }           // Başlık
        public string Description { get; set; }     // Açıklama
        public decimal Amount { get; set; }         // Tutar
        public DateTime IncomeDate { get; set; }    // Gelir tarihi
        public string UserName { get; set; }        // Kullanıcı adı
        public string CaseFileName { get; set; }    // Dosya adı
        public string CategoryName { get; set; }    // Kategori adı
        public DateTime CreatedDate { get; set; }
    }


}
