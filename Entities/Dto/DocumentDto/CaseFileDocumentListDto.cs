namespace Entities.Dto.DocumentDto
{
    public class CaseFileDocumentListDto
    {
        public int ID { get; set; }
        public string CaseFile { get; set; }
        public string DocumentType { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public string FileSizeFormatted { get; set; }
        public string FileUrl { get; set; }  // Web üzerinden erişim URL'i
        public DateTime CreatedDate { get; set; }
    }
}
