using Business.Exceptions.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions.CaseFileDocument
{
    public class CaseFileDocumentNotFoundException : NotFoundBaseException
    {
        public CaseFileDocumentNotFoundException(int id)
             : base($"ID'si {id} olan  Döküman Bulunamadı.")
        {
        }
    }
}
