using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
	public class CaseFileDocumentListDto
	{
		public int ID { get; set; }
		public string CaseFile { get; set; }
		public string DocumentType { get; set; }
		public string DocumentUrl { get; set; }

	}
}
