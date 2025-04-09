using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Security
{
    public class AccessToken  //Kullanıcı sisteme istekte bulunurken yetki gerektiren bir işlem yapıyorsa
                              //isteği gönderirken bir token'a ihtiyacı vardır. Bu classta da, o token'da olması gereken değerler var.
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } 
    }
}
