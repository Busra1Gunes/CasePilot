namespace Entities.Dto.HearingDto
{
    public class HearingUpdateDto
    {
        public int CourtID { get; set; }
        public DateTime HearingDate { get; set; }
        public TimeSpan HearingTime { get; set; }
        public string Judge { get; set; }
        public string Clerk { get; set; }
        public string Notes { get; set; }
        public string Result { get; set; }
        public int HearingStatus { get; set; }
        public DateTime? NextHearingDate { get; set; }
    }

}
