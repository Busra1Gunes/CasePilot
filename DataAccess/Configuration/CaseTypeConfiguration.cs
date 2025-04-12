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
    public class CaseTypeConfiguration : IEntityTypeConfiguration<CaseType>
    {
        public void Configure(EntityTypeBuilder<CaseType> builder)
        {

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.ToTable("CaseTypes"); 
            builder.HasMany(x => x.Dosyalar).WithOne().OnDelete(DeleteBehavior.Restrict); 



        }
    }
}
