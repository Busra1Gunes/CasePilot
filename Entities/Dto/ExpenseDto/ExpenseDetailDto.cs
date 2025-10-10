namespace Entities.Dto.ExpenseDto
{
    public class ExpenseDetailDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int? CaseFileID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int CategoryID { get; set; }
        public int PaymentStatus { get; set; }
        public string UserName { get; set; }
        public string CaseFileName { get; set; }
        public string CategoryName { get; set; }
        public string PaymentStatusName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
