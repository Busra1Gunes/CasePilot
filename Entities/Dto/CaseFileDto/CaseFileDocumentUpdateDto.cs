using Microsoft.AspNetCore.Http;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileDocumentUpdateDto
    {
        public int ID { get; set; }
        public int CaseFileID { get; set; }
        public int DocumentTypeID { get; set; }
        public IFormFile? DocumentUrl { get; set; }  // Yeni dosya (opsiyonel)
    }
}
