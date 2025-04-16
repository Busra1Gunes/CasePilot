using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace DataAccess.Configuration
{
    public class CaseFileConfiguration : IEntityTypeConfiguration<CaseFile>
    {
        public void Configure(EntityTypeBuilder<CaseFile> builder)
        {

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.HasOne(cf => cf.CaseType)
                   .WithMany(ct => ct.CaseFiles)
                   .HasForeignKey(cf => cf.CaseTypeID)
                   .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(x => x.City)
                   .WithMany(i => i.CaseFiles)
                   .HasForeignKey(x => x.CityID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.District)
                   .WithMany(ilce => ilce.CaseFiles)
                   .HasForeignKey(x => x.DistrictID)
                   .OnDelete(DeleteBehavior.Restrict); 

            builder.Property(x => x.EntitlementRate)
                   .HasPrecision(18, 2);

            builder.Property(x => x.DisabilityRate)
                   .HasPrecision(18, 2);



            builder.ToTable("CaseFiles");
        }
    }
}