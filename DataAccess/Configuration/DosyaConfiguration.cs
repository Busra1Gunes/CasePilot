using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class DosyaConfiguration : IEntityTypeConfiguration<Dosya>
    {
        public void Configure(EntityTypeBuilder<Dosya> builder)
        {

            // Primary Key
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            // Adi Alanı
            builder.Property(x => x.Adi).IsRequired().HasMaxLength(200);

            // Tablo Adı
            builder.ToTable("Dosyalar");

            // Foreign Key Tanımları ve OnDelete Restrict ile Cascade Path Problemini Çözme
            builder.HasOne(x => x.DavaTur)
                   .WithMany(d => d.Dosyalar)
                   .HasForeignKey(x => x.davaturId)
                   .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engellemek için 'Restrict'

            //builder.HasOne(x => x.BasvuruTur)
            //       .WithMany(b => b.Dosyalar)
            //       .HasForeignKey(x => x.basvuruturId)
            //       .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engelle

            builder.HasOne(x => x.Il)
                   .WithMany(i => i.Dosyalar)
                   .HasForeignKey(x => x.ilId)
                   .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engelle

            builder.HasOne(x => x.Ilce)
                   .WithMany(ilce => ilce.Dosyalar)
                   .HasForeignKey(x => x.ilceId)
                   .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engelle

            // Diğer alanlar
            builder.Property(x => x.HaklilikOrani)
                   .HasPrecision(18, 2); // decimal alanın precision ve scale'ını belirtiyoruz

            builder.Property(x => x.SakatlikOrani)
                   .HasPrecision(18, 2); // Aynı şekilde
        }
    }
}