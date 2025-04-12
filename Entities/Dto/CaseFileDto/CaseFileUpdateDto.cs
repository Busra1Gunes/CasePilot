using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileUpdateDto:CaseFileAddDto
    {
        public int ID { get; set; }
        public int caseTypeID { get; set; }
        public int applicationTypeID { get; set; }
        public int cityID { get; set; }
        public int districtID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public decimal HaklilikOrani { get; set; }
        public decimal SakatlikOrani { get; set; }
        public DateTime KazaTarihi { get; set; }
    }
}
