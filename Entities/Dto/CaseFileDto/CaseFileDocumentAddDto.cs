using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileDocumentAddDto
    {
        public int CaseFileID { get; set; }
        public int DocumentTypeID { get; set; }
        public IFormFile? DocumentUrl { get; set; }  // Dosya burada
    }
}
