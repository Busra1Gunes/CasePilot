using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Dosya :Entity, IEntity
	{
		public int Id { get; set; }
        public int DavaTurId { get; set; }
        public int BasvuruTurId { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
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
        public int DosyaDurum { get; set; }

    }
}
