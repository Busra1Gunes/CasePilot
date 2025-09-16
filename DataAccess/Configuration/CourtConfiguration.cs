using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public partial class CourtConfiguration : IEntityTypeConfiguration<Court>
{

    public void Configure(EntityTypeBuilder<Court> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Address).HasMaxLength(500);
        builder.Property(x => x.Phone).HasMaxLength(20);
        builder.Property(x => x.Email).HasMaxLength(100);
        builder.Property(x => x.CourtType).HasMaxLength(100);

        builder.HasOne(x => x.City)
               .WithMany()
               .HasForeignKey(x => x.CityID)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.District)
               .WithMany()
               .HasForeignKey(x => x.DistrictID)
               .OnDelete(DeleteBehavior.NoAction);

        builder.ToTable("Courts");

    }
}

