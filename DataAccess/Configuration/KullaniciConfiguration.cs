using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Configuration
{
    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            //builder.HasOne(x => x.firma).WithMany(x => x.subelers).HasForeignKey(x => x.firma_kodu);
            builder.HasOne(x => x.Il).WithMany(x => x.Kullanicilar).HasForeignKey(x => x.IlId);
            builder.HasOne(x => x.Ilce).WithMany(x => x.Kullanicilar).HasForeignKey(x => x.IlceId);

            builder.ToTable("kullanicilar");
        }
    }
}
