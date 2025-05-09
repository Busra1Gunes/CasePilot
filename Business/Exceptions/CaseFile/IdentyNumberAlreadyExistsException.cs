using Business.Exceptions.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions.CaseFile
{
    public class IdentyNumberAlreadyExistsException : BadRequestBaseException
    {
        public IdentyNumberAlreadyExistsException() : base("Bu Tc Kimlik No Daha Önce Kullanılmış")
        {
        }
    }
}
