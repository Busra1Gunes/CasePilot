namespace Entities.Dto.CourtDto
{
    public class CourtUpdateDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CourtType { get; set; }
    }

}
