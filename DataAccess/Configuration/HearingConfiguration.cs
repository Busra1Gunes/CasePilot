using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
public partial class CourtConfiguration
{
    public class HearingConfiguration : IEntityTypeConfiguration<Hearing>
    {
        public void Configure(EntityTypeBuilder<Hearing> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();

            builder.Property(x => x.Judge).HasMaxLength(200);
            builder.Property(x => x.Clerk).HasMaxLength(200);
            builder.Property(x => x.Notes).HasMaxLength(1000);
            builder.Property(x => x.Result).HasMaxLength(1000);

            builder.HasOne(x => x.CaseFile)
                   .WithMany(cf => cf.Hearings)
                   .HasForeignKey(x => x.CaseFileID)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Court)
                   .WithMany(c => c.Hearings)
                   .HasForeignKey(x => x.CourtID)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Hearings");
        }
    }
}

