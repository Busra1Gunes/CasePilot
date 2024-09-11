using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Hareket
    public class Movement
    {
        public int Id { get; set; }
        //Hareket Adı
        public string MovementName { get; set; }

        public ICollection<Stock_Movement> Stock_Movements { get; set; }
    }
}
