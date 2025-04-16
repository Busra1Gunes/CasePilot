using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class CaseFileDocumentConfiguration : IEntityTypeConfiguration<CaseFileDocument>
    {
        public void Configure(EntityTypeBuilder<CaseFileDocument> builder)
        {
            // Birincil anahtar tanımlama
            builder.HasKey(de => de.ID);
            builder.Property(de => de.ID).UseIdentityColumn();

            // Zorunlu alanlar
            builder.Property(de => de.CaseFileID).IsRequired();
            builder.Property(de => de.DocumentTypeID).IsRequired();
            builder.Property(de => de.DocumentUrl)
                   .IsRequired()
                   .HasMaxLength(500); // URL için uzunluk sınırı koyduk

            // İlişkiler
            builder.HasOne(x => x.CaseFile)
        .WithMany(x => x.CaseFileDocuments) // Eğer CaseFile içinde ICollection varsa
        .HasForeignKey(x => x.CaseFileID)
        .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DocumentType)
                .WithMany() // DocumentType tarafında ICollection yoksa böyle olmalı
                .HasForeignKey(x => x.DocumentTypeID)
                .OnDelete(DeleteBehavior.Restrict);
            // Tablo adını belirleme
            builder.ToTable("CaseFileDocument");
            // builder.Ignore(i => i.SilinmeTarihi); Ignore ile belirtilen alan veritabanına kaydedilmez
        }
    }
}
