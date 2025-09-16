namespace Entities.Dto.CourtDto
{
    public class CourtFilterDto
    {
        public string Name { get; set; }
        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public string CourtType { get; set; }
    }
}
