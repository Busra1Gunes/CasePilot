using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Seeds
{
    public class DocumentTypeSeed : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.HasData(new DocumentType { ID = 1, Name = "TcKimlik", Type = "DosyaEvrak", Durum = false },
          new DocumentType { ID = 2, Name = "Sici Kaydı", Type = "KullaniciEvrak", Durum = false });
        }
    }
}
