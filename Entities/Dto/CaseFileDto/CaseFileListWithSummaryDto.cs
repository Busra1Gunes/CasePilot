using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
    public class CaseFileListWithSummaryDto
    {
        public List<CaseFileListDto> CaseFiles { get; set; } = new();
        public int TotalCaseFiles { get; set; }
        public List<UserExpenseSummaryDto> TotalExpensesByUser { get; set; } = new();
        public decimal TotalExpenses { get; set; }
    }
}
