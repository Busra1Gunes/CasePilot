using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
    public class CaseFileListWithSummaryDto
    {
        public List<CaseFileListDto> CaseFiles { get; set; } = new List<CaseFileListDto>();

        public int TotalCaseFiles { get; set; }

        public List<UserExpenseSummaryDto> TotalExpensesByUser { get; set; } = new List<UserExpenseSummaryDto>();

        public decimal TotalExpenses { get; set; }
    }
}
