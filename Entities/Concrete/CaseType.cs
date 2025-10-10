using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseType : Entity //Dava Türü
    {
        public string Name { get; set; }
        public ICollection<CaseFile> CaseFiles { get; set; }

    }
}
