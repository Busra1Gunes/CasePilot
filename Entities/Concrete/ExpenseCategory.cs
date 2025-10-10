namespace Entities.Concrete
{
    // Gider kategorisi
    public class ExpenseCategory : Entity
    {
        public string Name { get; set; }              // Kategori adı
        public string Description { get; set; }       // Açıklama

        // Navigation Properties
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
