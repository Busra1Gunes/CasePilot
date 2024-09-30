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
    public class DavaTurConfiguration : IEntityTypeConfiguration<DavaTur>
    {
        public void Configure(EntityTypeBuilder<DavaTur> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Adi).IsRequired().HasMaxLength(200);
            builder.ToTable("DavaTurleri"); 
            builder.HasMany(x => x.Dosyalar).WithOne().OnDelete(DeleteBehavior.Restrict); 



        }
    }
}
