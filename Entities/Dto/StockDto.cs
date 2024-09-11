using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class StockDto
    {
        //Tedarikçi Kimliği
        public int SupplierID { get; set; }
        public string StockName { get; set; }
        //Miktar
        public int? Quantity { get; set; }
        //Birim Fiyat
        public decimal? UnitPrice { get; set; }
        //Toplam Değer
        public int? TotalValue { get; set; }
        //Açıklama
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
