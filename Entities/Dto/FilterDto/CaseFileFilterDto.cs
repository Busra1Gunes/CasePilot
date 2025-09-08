using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.FilterDto
{
    public class CaseFileFilterDto
    {
        public int? CaseTypeID { get; set; }
        public int? ApplicationTypeID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? IdentityNumber { get; set; }
        public string? FileNumber { get; set; }
        public string? ShareUserName { get; set; }
        public string? DefendantName { get; set; }
    }
}
