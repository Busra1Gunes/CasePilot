using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DocumentType : Entity, IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }  //Dosya Evrakları, Kullanıcı Evrakları

        public ICollection<CaseFileDocument> CaseFileDocument { get; set; } // İlişkili dosya evrakları
    }
}
