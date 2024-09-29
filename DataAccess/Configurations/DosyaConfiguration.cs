using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Configurations
{
	public class DosyaConfiguration : IEntityTypeConfiguration<Dosya>
	{
		public void Configure(EntityTypeBuilder<Dosya> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.davaturId).IsRequired();
			builder.Property(b => b.basvuruturId).IsRequired();
			builder.Property(b => b.ilId).IsRequired();
			builder.Property(b => b.ilceId).IsRequired();
			//builder.HasOne(b => b.DavaTur).WithMany(c => c.Dosyalar).HasForeignKey(c => c.davaturId);
			//builder.HasOne(b => b.BasvuruTur).WithMany(c => c.Dosyalar).HasForeignKey(c => c.basvuruturId);

			builder.ToTable("dosyalar");
		}
	}
}
