using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Entities.Seeds
{
    public class IncomeCategorySeed : IEntityTypeConfiguration<IncomeCategory>
    {   // Gelir Kategorileri Seed - Income Categories Seed
        public void Configure(EntityTypeBuilder<IncomeCategory> builder)
            {
                builder.HasData(
                    new IncomeCategory
                    {
                        ID = 1,
                        Name = "Avukatlık Ücreti",
                        Description = "Müvekkil avukatlık ve danışmanlık ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 2,
                        Name = "Vekalet Ücreti",
                        Description = "Dava vekalet ücret gelirleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 3,
                        Name = "Danışmanlık Ücreti",
                        Description = "Hukuki danışmanlık hizmet gelirleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 4,
                        Name = "Arabuluculuk Ücreti",
                        Description = "Arabuluculuk hizmet gelirleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 5,
                        Name = "Sözleşme Hazırlama",
                        Description = "Sözleşme hazırlama ve inceleme ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 6,
                        Name = "Mahkeme Gideri İadesi",
                        Description = "Müvekkilden mahkeme masrafları iadesi",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 7,
                        Name = "İcra Tahsilat",
                        Description = "İcra dosyalarından yapılan tahsilatlar",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 8,
                        Name = "Dosya Kapatma Ücreti",
                        Description = "Dosya sonuçlandırma ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 9,
                        Name = "Başarı Primi",
                        Description = "Dava kazanma başarı primleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new IncomeCategory
                    {
                        ID = 10,
                        Name = "Diğer Gelirler",
                        Description = "Diğer hukuki hizmet gelirleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    }
                );
            }
        }
    
    }
