using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum HareketTuru
    {
        Maas,        // Maaş Geliri
        Fatura,      // Fatura Ödemesi
        Kira,        // Kira Ödemesi veya Geliri
        DosyaMasrafi, // Dosya Masrafı
        Transfer,    // Hesaplar Arası Transfer
        Diger        // Diğer İşlemler
    }
}
