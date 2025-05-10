using Business.Exceptions.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions.CaseFileDocument
{
    public class FileUploadException : NotFoundBaseException
    {
        public FileUploadException() : base("Dosya Yüklenirken Hata Oluştu")
        {
        }
    }
}
