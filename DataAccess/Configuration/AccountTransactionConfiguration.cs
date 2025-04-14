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
    public class AccountTransactionConfiguration : IEntityTypeConfiguration<AccountTransaction>
    {
        public void Configure(EntityTypeBuilder<AccountTransaction> builder)
        {
            builder.ToTable("HesapHareketler");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();

            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Status).HasDefaultValue(false);
            builder.Property(x => x.CaseFileID).HasDefaultValue(null);
           
            //builder.Property(x => x.HareketDurumu).HasDefaultValue((byte)HareketDurumu.Borc);
            //builder.Property(x => x.HareketTuru).HasDefaultValue((byte)HareketTuru.Transfer);

            builder.HasOne(x => x.User1)
      .WithMany(x => x.HesapHareket1)
      .HasForeignKey(x => x.DebtorID)
      .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.User2)
                .WithMany(x => x.HesapHareket2)
                .HasForeignKey(x => x.CreditID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
