using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Hearing.cs - Duruşma Entity
    public class Hearing : Entity
    {
        public int CaseFileID { get; set; }
        public int? CourtID { get; set; }
        public DateTime HearingDate { get; set; }
        public TimeSpan HearingTime { get; set; }
        public string Judge { get; set; }
        public string Clerk { get; set; } // Katip
        public string Notes { get; set; }
        public string Result { get; set; } // Duruşma sonucu
        public int HearingStatus { get; set; } // 1=Planlandı, 2=Yapıldı, 3=Ertelendi, 4=İptal
        public DateTime? NextHearingDate { get; set; } // Sonraki duruşma tarihi

        // Navigation Properties
        public CaseFile CaseFile { get; set; }
        public Court Court { get; set; }
    }
}
