using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.DosyaDto
{
	public class DosyaDetayDto
	{
        public int Id { get; set; }
        public string DavaTur { get; set; }
		public string BasvuruTur { get; set; }
		public string Il { get; set; }
		public string Ilce { get; set; }
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string Tc { get; set; }
		public string Telefon { get; set; }
		public DateTime DogumTarihi { get; set; }
		public decimal HaklilikOrani { get; set; }
		public decimal SakatlikOrani { get; set; }
		public DateTime KazaTarihi { get; set; }
		public DateTime AcilisTarihi { get; set; }
		public DateTime KapanisTarihi { get; set; }
	}
}
