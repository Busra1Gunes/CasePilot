using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Enums;

namespace DataAccess.Configuration
{
    public class HesapHareketConfiguration : IEntityTypeConfiguration<HesapHareket>
    {
        public void Configure(EntityTypeBuilder<HesapHareket> builder)
        {
            builder.ToTable("HesapHareketler");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Aciklama).HasMaxLength(500);
            builder.Property(x => x.Durum).HasDefaultValue(false);
            builder.Property(x => x.DosyaId).HasDefaultValue(null);
           
            //builder.Property(x => x.HareketDurumu).HasDefaultValue((byte)HareketDurumu.Borc);
            //builder.Property(x => x.HareketTuru).HasDefaultValue((byte)HareketTuru.Transfer);

            builder.HasOne(x => x.Kullanici1)
      .WithMany(x => x.HesapHareket1)
      .HasForeignKey(x => x.BorcluID)
      .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Kullanici2)
                .WithMany(x => x.HesapHareket2)
                .HasForeignKey(x => x.AlacakId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
