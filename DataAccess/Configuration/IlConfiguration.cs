using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configurations
{
    public class IlConfiguration : IEntityTypeConfiguration<Il>
    {
        public void Configure(EntityTypeBuilder<Il> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Adi).IsRequired().HasMaxLength(50);
            

            builder.ToTable("Iller");
        }
    }
}
