using Business.Exceptions.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions.CaseFile
{
    public class InvalidCaseFileException : NotFoundBaseException
    {
        public InvalidCaseFileException() : base("CaseFile nesnesi null veya boş gönderilemez")
        {
        }
    }
}
