using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.ExpenseDto
{
    public class ExpenseAddDto
    {
        public int UserID { get; set; }           // Kullanıcı ID
        public int? CaseFileID { get; set; }      // Dosya ID (opsiyonel)
        public string Title { get; set; }         // Başlık
        public string Description { get; set; }   // Açıklama
        public decimal Amount { get; set; }       // Tutar
        public DateTime ExpenseDate { get; set; } // Gider tarihi
        public int CategoryID { get; set; }       // Kategori ID
        public int PaymentStatus { get; set; }    // Ödeme durumu
    }
}
