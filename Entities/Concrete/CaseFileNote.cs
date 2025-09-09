using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseFileNote:Entity
    {
        public int CaseFileID { get; set; }   // Hangi dosyaya bağlı
        public int UserID { get; set; }       // Notu ekleyen kullanıcı
        public string Content { get; set; }   // Not içeriği
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation Properties
        public virtual CaseFile CaseFile { get; set; }
        public virtual User User { get; set; }
    }
}
