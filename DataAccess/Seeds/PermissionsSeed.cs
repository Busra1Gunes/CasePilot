using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class PermissionsSeed : IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
        {
            builder.HasData(
                // ===== USERS =====
                new Permissions { ID = 1, Name = "Kullanıcı Listeleme Yetkisi", Code = "list-user", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 2, Name = "Kullanıcı Ekleme Yetkisi", Code = "add-user", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 3, Name = "Kullanıcı Güncelleme Yetkisi", Code = "update-user", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 4, Name = "Kullanıcı Silme Yetkisi", Code = "delete-user", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 5, Name = "Kullanıcı Giriş Yetkisi", Code = "login-user", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 6, Name = "Kullanıcı Şifre Güncelleme Yetkisi", Code = "change-password", Status = true, CreatedDate = DateTime.Now },

                // ===== ROLES =====
                new Permissions { ID = 7, Name = "Rol Listeleme Yetkisi", Code = "list-role", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 8, Name = "Rol Ekleme Yetkisi", Code = "add-role", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 9, Name = "Rol Güncelleme Yetkisi", Code = "update-role", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 10, Name = "Rol Silme Yetkisi", Code = "delete-role", Status = true, CreatedDate = DateTime.Now },

                // ===== PERMISSIONS =====
                new Permissions { ID = 11, Name = "Yetki Listeleme Yetkisi", Code = "list-permission", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 12, Name = "Yetki Ekleme Yetkisi", Code = "add-permission", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 13, Name = "Yetki Güncelleme Yetkisi", Code = "update-permission", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 14, Name = "Yetki Silme Yetkisi", Code = "delete-permission", Status = true, CreatedDate = DateTime.Now },

                // ===== CASE FILE =====
                new Permissions { ID = 15, Name = "Dosya Listeleme Yetkisi", Code = "list-casefile", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 16, Name = "Dosya Ekleme Yetkisi", Code = "add-casefile", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 17, Name = "Dosya Güncelleme Yetkisi", Code = "update-casefile", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 18, Name = "Dosya Silme Yetkisi", Code = "delete-casefile", Status = true, CreatedDate = DateTime.Now },

                // ===== CASE FILE DEFENDANTS =====
                new Permissions { ID = 19, Name = "Dosya Sanık Listeleme Yetkisi", Code = "list-casefiledefendant", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 20, Name = "Dosya Sanık Ekleme Yetkisi", Code = "add-casefiledefendant", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 21, Name = "Dosya Sanık Güncelleme Yetkisi", Code = "update-casefiledefendant", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 22, Name = "Dosya Sanık Silme Yetkisi", Code = "delete-casefiledefendant", Status = true, CreatedDate = DateTime.Now },

                // ===== CASE FILE SHARES =====
                new Permissions { ID = 23, Name = "Dosya Pay Listeleme Yetkisi", Code = "list-casefileshare", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 24, Name = "Dosya Pay Ekleme Yetkisi", Code = "add-casefileshare", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 25, Name = "Dosya Pay Silme Yetkisi", Code = "delete-casefileshare", Status = true, CreatedDate = DateTime.Now },

                // ===== ACCOUNT TRANSACTIONS =====
                new Permissions { ID = 26, Name = "Hesap Hareketi Listeleme Yetkisi", Code = "list-transaction", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 27, Name = "Hesap Hareketi Ekleme Yetkisi", Code = "add-transaction", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 28, Name = "Hesap Hareketi Güncelleme Yetkisi", Code = "update-transaction", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 29, Name = "Hesap Hareketi Silme Yetkisi", Code = "delete-transaction", Status = true, CreatedDate = DateTime.Now },

                // ===== EXPENSE =====
                new Permissions { ID = 30, Name = "Gider Listeleme Yetkisi", Code = "list-expense", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 31, Name = "Gider Ekleme Yetkisi", Code = "add-expense", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 32, Name = "Gider Güncelleme Yetkisi", Code = "update-expense", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 33, Name = "Gider Silme Yetkisi", Code = "delete-expense", Status = true, CreatedDate = DateTime.Now },

                // ===== INCOME =====
                new Permissions { ID = 34, Name = "Gelir Listeleme Yetkisi", Code = "list-income", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 35, Name = "Gelir Ekleme Yetkisi", Code = "add-income", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 36, Name = "Gelir Güncelleme Yetkisi", Code = "update-income", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 37, Name = "Gelir Silme Yetkisi", Code = "delete-income", Status = true, CreatedDate = DateTime.Now },

                // ===== CASE TYPES =====
                new Permissions { ID = 38, Name = "Dava Türü Listeleme Yetkisi", Code = "list-casetype", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 39, Name = "Dava Türü Ekleme Yetkisi", Code = "add-casetype", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 40, Name = "Dava Türü Silme Yetkisi", Code = "delete-casetype", Status = true, CreatedDate = DateTime.Now },

                // ===== COURT =====
                new Permissions { ID = 41, Name = "Mahkeme Listeleme Yetkisi", Code = "list-court", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 42, Name = "Mahkeme Ekleme Yetkisi", Code = "add-court", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 43, Name = "Mahkeme Güncelleme Yetkisi", Code = "update-court", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 44, Name = "Mahkeme Silme Yetkisi", Code = "delete-court", Status = true, CreatedDate = DateTime.Now },

                // ===== HEARING =====
                new Permissions { ID = 45, Name = "Duruşma Listeleme Yetkisi", Code = "list-hearing", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 46, Name = "Duruşma Ekleme Yetkisi", Code = "add-hearing", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 47, Name = "Duruşma Güncelleme Yetkisi", Code = "update-hearing", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 48, Name = "Duruşma Silme Yetkisi", Code = "delete-hearing", Status = true, CreatedDate = DateTime.Now },

                // ===== DOCUMENTS =====
                new Permissions { ID = 49, Name = "Belge Listeleme Yetkisi", Code = "list-document", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 50, Name = "Belge Ekleme Yetkisi", Code = "add-document", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 51, Name = "Belge Güncelleme Yetkisi", Code = "update-document", Status = true, CreatedDate = DateTime.Now },
                new Permissions { ID = 52, Name = "Belge Silme Yetkisi", Code = "delete-document", Status = true, CreatedDate = DateTime.Now }
            );
        }
    }
}
