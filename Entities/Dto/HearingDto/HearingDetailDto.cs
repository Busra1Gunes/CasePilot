namespace Entities.Dto.HearingDto
{
    public class HearingDetailDto
    {
        public int ID { get; set; }
        public int CaseFileID { get; set; }
        public string CaseFileName { get; set; }
        public string CaseFileNumber { get; set; }
        public int CourtID { get; set; }
        public string CourtName { get; set; }
        public string CourtAddress { get; set; }
        public DateTime HearingDate { get; set; }
        public TimeSpan HearingTime { get; set; }
        public string Judge { get; set; }
        public string Clerk { get; set; }
        public string Notes { get; set; }
        public string Result { get; set; }
        public int HearingStatus { get; set; }
        public string HearingStatusName { get; set; }
        public DateTime? NextHearingDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}
