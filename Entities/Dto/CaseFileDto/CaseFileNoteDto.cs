using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
    public class CaseFileNoteListDto
    {
        public int ID { get; set; }
        public string CaseFile { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
        public DateTime NoteDate { get; set; }
    }
}
