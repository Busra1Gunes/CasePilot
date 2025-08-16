using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Permissions : Entity
    {
        public string Name { get; set; } //Yetki adı (Firma_Listele, Firma_Sil)
        public string Code { get; set; }
    }
}
