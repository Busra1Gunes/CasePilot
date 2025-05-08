using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DocumentType : Entity
    {
        public string Name { get; set; }

        public string Type { get; set; }  //Dosya Evrakları, Kullanıcı Evrakları

        public ICollection<CaseFileDocument> CaseFileDocuments { get; set; } // İlişkili dosya evrakları
    }
}
