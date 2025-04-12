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
        public int caseFileID { get; set; }

        public int documentId { get; set; }
        public IFormFile? documentUrl { get; set; }
    }
}
