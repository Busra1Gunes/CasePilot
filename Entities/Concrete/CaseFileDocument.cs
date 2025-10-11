using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseFileDocument : Entity
    {
        public int CaseFileID { get; set; }
        public int DocumentTypeID { get; set; }
        public string FileName { get; set; }           // Orijinal dosya adı
        public string FileExtension { get; set; }      // Uzantı (.pdf, .docx)
        public string FilePath { get; set; }           // Dosya yolu (wwwroot/uploads/documents/...)
        public long FileSize { get; set; }             // Dosya boyutu (byte)
        public string ContentType { get; set; }        // MIME tipi

        // Navigation Properties
        public virtual CaseFile CaseFile { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}
