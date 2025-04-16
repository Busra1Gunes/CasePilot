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
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(100);

            // CaseFileDocuments ilişkisi
            builder.HasMany(x => x.CaseFileDocuments)
                .WithOne(x => x.DocumentType)
                .HasForeignKey(x => x.DocumentTypeID)
                .OnDelete(DeleteBehavior.Restrict); // veya Cascade, senin ihtiyacına göre

            // Not: Eğer CaseFileDocument içinde başka bir `DocumentTypeID1` vs gibi navigation varsa ona dikkar
        }
    }
}
