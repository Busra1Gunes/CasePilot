using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Stok Hareketleri
    public class Stock_Movement
    {
        public int Id { get; set; }
        public int stockID { get; set; }
        //Hareket id
        public int movementId{ get; set; }
        //Miktar
        public decimal Quantity { get; set; }
        public DateTime movementDate { get; set; }


        public Stock Stock { get; set; }
        public Movement Movement { get; set; }
    }
}
