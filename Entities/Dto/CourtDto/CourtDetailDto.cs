using Entities.Dto.HearingDto;

namespace Entities.Dto.CourtDto
{
    public class CourtDetailDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CourtType { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<HearingListDto> Hearings { get; set; }
    }

}
