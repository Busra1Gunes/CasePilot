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
    public class CaseFileConfiguration : IEntityTypeConfiguration<CaseFile>
    {
        public void Configure(EntityTypeBuilder<CaseFile> builder)
        {

            // Primary Key
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();

            // Adi Alanı
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            // Tablo Adı
            builder.ToTable("CaseFiles");

            // Foreign Key Tanımları ve OnDelete Restrict ile Cascade Path Problemini Çözme
            builder.HasOne(x => x.CaseType)
                   .WithMany(d => d.CaseFiles)
                   .HasForeignKey(x => x.CaseTypeID)
                   .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engellemek için 'Restrict'

            //builder.HasOne(x => x.BasvuruTur)
            //       .WithMany(b => b.Dosyalar)
            //       .HasForeignKey(x => x.basvuruturId)
            //       .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engelle

            builder.HasOne(x => x.City)
                   .WithMany(i => i.CaseFiles)
                   .HasForeignKey(x => x.CityID)
                   .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engelle

            builder.HasOne(x => x.District)
                   .WithMany(ilce => ilce.CaseFiles)
                   .HasForeignKey(x => x.DistrictID)
                   .OnDelete(DeleteBehavior.Restrict); // Cascade Delete'i engelle

            // Diğer alanlar
            builder.Property(x => x.EntitlementRate)
                   .HasPrecision(18, 2); // decimal alanın precision ve scale'ını belirtiyoruz

            builder.Property(x => x.DisabilityRate)
                   .HasPrecision(18, 2); // Aynı şekilde
        }
    }
}