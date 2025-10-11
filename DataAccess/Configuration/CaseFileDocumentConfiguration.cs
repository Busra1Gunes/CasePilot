using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class CaseFileDocumentConfiguration : IEntityTypeConfiguration<CaseFileDocument>
    {
        public void Configure(EntityTypeBuilder<CaseFileDocument> builder)
        {

            builder.ToTable("CaseFileDocuments"); // Çoğul form öneriliyor


            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();


            builder.Property(x => x.CaseFileID)
                .IsRequired();

            builder.Property(x => x.DocumentTypeID)
                .IsRequired();



            // Dosya adı
            builder.Property(x => x.FileName)
                .IsRequired()
                .HasMaxLength(255);

            // Dosya uzantısı
            builder.Property(x => x.FileExtension)
                .IsRequired()
                .HasMaxLength(10);

            // Dosya yolu
            builder.Property(x => x.FilePath)
                .IsRequired()
                .HasMaxLength(500); // Dosya yolu için

            // Dosya boyutu
            builder.Property(x => x.FileSize)
                .IsRequired();

            // Content Type (MIME)
            builder.Property(x => x.ContentType)
                .IsRequired()
                .HasMaxLength(100);



            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedDate)
                .IsRequired(false);

            builder.Property(x => x.DeletedDate)
                .IsRequired(false);

            builder.Property(x => x.Status)
                .IsRequired()
                .HasDefaultValue(true);



            // CaseFile ile ilişki
            builder.HasOne(x => x.CaseFile)
                .WithMany(x => x.CaseFileDocuments)
                .HasForeignKey(x => x.CaseFileID)
                .OnDelete(DeleteBehavior.Restrict); // Cascade delete önleniyor

            // DocumentType ile ilişki
            builder.HasOne(x => x.DocumentType)
                .WithMany() // DocumentType'da navigation collection yoksa boş bırak
                .HasForeignKey(x => x.DocumentTypeID)
                .OnDelete(DeleteBehavior.Restrict);



            // CaseFileID üzerine index
            builder.HasIndex(x => x.CaseFileID)
                .HasDatabaseName("IX_CaseFileDocuments_CaseFileID");

            // DocumentTypeID üzerine index
            builder.HasIndex(x => x.DocumentTypeID)
                .HasDatabaseName("IX_CaseFileDocuments_DocumentTypeID");

            // Status üzerine index (soft delete için)
            builder.HasIndex(x => x.Status)
                .HasDatabaseName("IX_CaseFileDocuments_Status");

            // Composite index (CaseFileID + Status)
            builder.HasIndex(x => new { x.CaseFileID, x.Status })
                .HasDatabaseName("IX_CaseFileDocuments_CaseFileID_Status");
        }
    }
}
