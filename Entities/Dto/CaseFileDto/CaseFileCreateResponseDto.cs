namespace Entities.Dto.DosyaDto
{
    public class CaseFileCreateResponseDto
    {
        public int CaseFileID { get; set; }
        public int SharesCreated { get; set; }
        public int TransactionsCreated { get; set; }
        public string Message { get; set; }
    }
}
