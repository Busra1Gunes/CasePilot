using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.IncomeDto
{
    public class IncomeAddDto
    {
        public int UserID { get; set; }           // Kullanıcı ID
        public string Title { get; set; }         // Başlık
        public string Description { get; set; }   // Açıklama
        public decimal Amount { get; set; }       // Tutar
        public DateTime IncomeDate { get; set; }  // Gelir tarihi
        public int CategoryID { get; set; }       // Kategori ID
    }


}
