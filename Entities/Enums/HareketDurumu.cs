using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum HareketDurumu:byte
    {
        Borc=1,   // Borç (Ödeyen Taraf)
        Alacak =2 // Alacak (Alan Taraf)
    }
}
