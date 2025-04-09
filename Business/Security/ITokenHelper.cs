using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Security
{
    public interface ITokenHelper
    {
        //Bu metotla, token'ın kim için oluşturulacağını ve içerisine hangi yetkileri koyacağımızı belirleriz.
        AccessToken CreateToken(Kullanici kullanici);
    }
}
