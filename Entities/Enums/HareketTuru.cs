using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum HareketTuru:byte
    {
        Maas=1,        // Maaş Geliri
        Fatura=2,      // Fatura Ödemesi
        Kira=3,        // Kira Ödemesi veya Geliri
        DosyaMasrafi=4, // Dosya Masrafı
        Transfer=5,    // Hesaplar Arası Transfer
        Diger=6        // Diğer İşlemler
    }
}
