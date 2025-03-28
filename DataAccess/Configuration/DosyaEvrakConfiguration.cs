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
    public class DosyaEvrakConfiguration : IEntityTypeConfiguration<DosyaEvrak>
    {
        public void Configure(EntityTypeBuilder<DosyaEvrak> builder)
        {
            // Birincil anahtar tanımlama
            builder.HasKey(de => de.Id);
            builder.Property(de => de.Id).UseIdentityColumn();

            // Zorunlu alanlar
            builder.Property(de => de.DosyaId).IsRequired();
            builder.Property(de => de.EvrakId).IsRequired();
            builder.Property(de => de.EvrakUrl)
                   .IsRequired()
                   .HasMaxLength(500); // URL için uzunluk sınırı koyduk

            // İlişkiler
            builder.HasOne(de => de.Dosya)
                   .WithMany() // Eğer Dosya'nın birden çok DosyaEvrak kaydı olabilir ise
                   .HasForeignKey(de => de.DosyaId)
                   .OnDelete(DeleteBehavior.Restrict); // Silme kısıtlaması

            builder.HasOne(de => de.Evrak)
                   .WithMany() // Eğer EvrakTur'un birden çok DosyaEvrak kaydı olabilir ise
                   .HasForeignKey(de => de.EvrakId)
                   .OnDelete(DeleteBehavior.Restrict); // Silme kısıtlaması

            // Tablo adını belirleme
            builder.ToTable("dosya_evraklar");
            // builder.Ignore(i => i.SilinmeTarihi); Ignore ile belirtilen alan veritabanına kaydedilmez
        }
    }
}
