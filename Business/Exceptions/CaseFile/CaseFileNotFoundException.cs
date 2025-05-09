using Business.Exceptions.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions.CaseFile
{
    public class CaseFileNotFoundException : NotFoundBaseException
    {
        public CaseFileNotFoundException(int id)
             : base($"ID'si {id} olan dava dosyası bulunamadı.")
        {
        }
    }
}
