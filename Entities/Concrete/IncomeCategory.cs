namespace Entities.Concrete
{
    public class IncomeCategory : Entity
    {  // Gelir kategorisi
        public string Name { get; set; }              // Kategori adı
        public string Description { get; set; }       // Açıklama

        // Navigation Properties
        public virtual ICollection<Income> Incomes { get; set; }
    } 
}
