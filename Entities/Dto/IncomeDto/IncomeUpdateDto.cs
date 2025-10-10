namespace Entities.Dto.IncomeDto
{
    public class IncomeUpdateDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime IncomeDate { get; set; }
        public int CategoryID { get; set; }
    }


}
