namespace Entities.Dto.DocumentDto
{
    public class FileDownloadDto
    {// Dosya indirme DTO
        public byte[] FileData { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
    }
}
