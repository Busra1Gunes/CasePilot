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
            builder.HasOne(de => de.CaseFile)
                   .WithMany() // Eğer Dosya'nın birden çok DosyaEvrak kaydı olabilir ise
                   .HasForeignKey(de => de.CaseFileID)
                   .OnDelete(DeleteBehavior.Restrict); // Silme kısıtlaması

            builder.HasOne(de => de.DocumentType)
                   .WithMany() // Eğer EvrakTur'un birden çok DosyaEvrak kaydı olabilir ise
                   .HasForeignKey(de => de.DocumentTypeID)
                   .OnDelete(DeleteBehavior.Restrict); // Silme kısıtlaması

            // Tablo adını belirleme
            builder.ToTable("CaseFileDocument");
            // builder.Ignore(i => i.SilinmeTarihi); Ignore ile belirtilen alan veritabanına kaydedilmez
        }
    }
}
