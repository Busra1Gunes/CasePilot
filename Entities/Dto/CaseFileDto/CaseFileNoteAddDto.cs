using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
    public class CaseFileNoteAddDto
    {
        public int CaseFileID { get; set; }   
        public int UserID { get; set; }      
        public string Content { get; set; }  
        public DateTime NoteDate { get; set; }
    }
}
