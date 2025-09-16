namespace Entities.Dto.HearingDto
{
    public class HearingFilterDto
    {
        public int? CaseFileID { get; set; }
        public int? CourtID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Judge { get; set; }
        public int? HearingStatus { get; set; }
    }
}
