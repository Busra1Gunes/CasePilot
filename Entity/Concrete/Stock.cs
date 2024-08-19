using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Stock:IEntity
	{
        public int Id { get; set; }
		public int SupplierID { get; set; }
		public string StockName { get; set; }
        public int?  Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? TotalValue { get; set; }
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
