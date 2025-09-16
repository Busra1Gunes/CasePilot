using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HearingDto
{

    public class HearingAddDto
    {
        public int CaseFileID { get; set; }
        public int CourtID { get; set; }
        public DateTime HearingDate { get; set; }
        public TimeSpan HearingTime { get; set; }
        public string Judge { get; set; }
        public string Clerk { get; set; }
        public string Notes { get; set; }
        public DateTime? NextHearingDate { get; set; }
    }
}
