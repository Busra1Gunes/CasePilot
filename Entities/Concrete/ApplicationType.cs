using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ApplicationType:Entity,IEntity //Basvuru Türü
    {
        public int ID { get; set; }
        public int CaseTypeID { get; set; } 
        public string Name { get; set; } 


        //public ICollection<Dosya> Dosyalar { get;set; }
        //public DavaTur DavaTur { get; set; }
    }
}
