using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.DocumentDto
{
    public class DocumentTypeListDto
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }  //Dosya Evrakları, Kullanıcı Evrakları
    }
}
