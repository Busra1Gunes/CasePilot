using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Entities.Seeds
{
    public class ExpenseCategorySeed : IEntityTypeConfiguration<ExpenseCategory>
    { // Gider Kategorileri Seed - Expense Categories Seed
        public void Configure(EntityTypeBuilder<ExpenseCategory> builder)
            {
                builder.HasData(
                    new ExpenseCategory
                    {
                        ID = 1,
                        Name = "Mahkeme Harçları",
                        Description = "Dava açılış, temyiz ve diğer mahkeme harçları",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 2,
                        Name = "Bilirkişi Ücreti",
                        Description = "Bilirkişi inceleme ve rapor ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 3,
                        Name = "Noter Masrafı",
                        Description = "Noter onay ve tasdik masrafları",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 4,
                        Name = "Tebligat Gideri",
                        Description = "Posta ve tebligat masrafları",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 5,
                        Name = "Yol Masrafı",
                        Description = "Duruşma ve iş gezisi yol masrafları",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 6,
                        Name = "Dosya Fotokopi",
                        Description = "Evrak fotokopi ve çoğaltma giderleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 7,
                        Name = "İcra Takip Masrafı",
                        Description = "İcra dairesi masraf ve avans giderleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 8,
                        Name = "Tercüme Ücreti",
                        Description = "Yeminli tercüman ve tercüme ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 9,
                        Name = "Ofis Kira",
                        Description = "Ofis kira ödemeleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 10,
                        Name = "Personel Maaş",
                        Description = "Çalışan personel maaş ödemeleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 11,
                        Name = "Elektrik-Su-Doğalgaz",
                        Description = "Ofis elektrik, su ve doğalgaz faturaları",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 12,
                        Name = "İnternet-Telefon",
                        Description = "İnternet ve telefon abonelik ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 13,
                        Name = "Kırtasiye Malzeme",
                        Description = "Ofis kırtasiye ve malzeme alımları",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 14,
                        Name = "Yazılım Lisans",
                        Description = "Hukuk yazılım ve program lisans ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 15,
                        Name = "Baro Aidat",
                        Description = "Baro üyelik aidat ödemeleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 16,
                        Name = "Vergi Ödemesi",
                        Description = "Gelir vergisi ve diğer vergi ödemeleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 17,
                        Name = "Sigorta Ödemesi",
                        Description = "Mesleki sorumluluk ve diğer sigorta ödemeleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 18,
                        Name = "Eğitim-Seminer",
                        Description = "Mesleki eğitim ve seminer katılım ücretleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 19,
                        Name = "Araç Yakıt",
                        Description = "İş amaçlı araç yakıt giderleri",
                        CreatedDate = DateTime.Now,
                        Status = true
                    },
                    new ExpenseCategory
                    {
                        ID = 20,
                        Name = "Diğer Giderler",
                        Description = "Diğer ofis ve dava masrafları",
                        CreatedDate = DateTime.Now,
                        Status = true
                    }
                );
            }
        }
    
    }
