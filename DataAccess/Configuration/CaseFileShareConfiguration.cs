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
    public class CaseFileShareConfiguration : IEntityTypeConfiguration<CaseFileShare>
    {
        public void Configure(EntityTypeBuilder<CaseFileShare> builder)
        {
            builder.Property(x => x.ShareRate)
                   .HasColumnType("decimal(18,2)"); // veya .HasPrecision(18, 2);
        }
    }
}
