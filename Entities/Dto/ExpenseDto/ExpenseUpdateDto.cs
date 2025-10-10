namespace Entities.Dto.ExpenseDto
{
    public class ExpenseUpdateDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int CategoryID { get; set; }
        public int PaymentStatus { get; set; }
    }
}
