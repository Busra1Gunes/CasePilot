namespace Entities.Dto.CaseFileDto
{
    public class UserExpenseSummaryDto
    {
        public string UserFullName { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal UnpaidAmount { get; set; }
        public decimal TotalAmount => PaidAmount + UnpaidAmount;
    }
}
