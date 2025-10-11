namespace Entities.Dto.DocumentDto
{
    public class CaseFileDocumentDetailDto : CaseFileDocumentListDto
    {
        public int CaseFileID { get; set; }
        public int DocumentTypeID { get; set; }
        public string ContentType { get; set; }
    }
}
